using System.Buffers;
using System.Net.Sockets;
using Serilog;
using Snouthill.Game;
using Snouthill.Net.Packets;
using Snouthill.Util;

namespace Snouthill.Net;

public class GameClient : AClient
{
    private readonly IRequestDispatcher _requestDispatcher;

    public GameClient(Socket socket, IRequestDispatcher requestDispatcher) : base(socket)
    {
        _requestDispatcher = requestDispatcher;
        Player = new Player(this);
    }

    public Player Player { get; }

    public void Send(IResponse packet)
    {
        Log.Debug("Outgoing packet: {packet}", packet.ToString());

        var writer = new PacketWriter();

        writer.WriteOpcode(packet.Opcode);
        packet.Serialize(writer);
        writer.WriteEndOfPacket();

        Send(writer.ToArray());
    }

    protected override void ProcessPackets(ref ReadOnlySequence<byte> buffer)
    {
        // Keep parsing packets while there's enough data
        while (buffer.Length >= 5)
        {
            var header = buffer.Slice(0, 3).ToArray();
            var length = Base64Encoding.Decode(header);
            if (length > buffer.Length) break;

            var data = buffer.Slice(3, length).ToArray();
            ProcessPacket(data);

            var next = buffer.GetPosition(3 + length);
            buffer = buffer.Slice(next);
        }
    }

    private void ProcessPacket(ReadOnlySpan<byte> buffer)
    {
        var reader = new PacketReader(buffer);
        var opcode = reader.ReadBase64Short();

        IRequest? request;
        try
        {
            request = _requestDispatcher.Deserialize(opcode, reader);
            if (request == null)
            {
                Log.Warning("Unknown packet: {hexPacket} (opcode {opcode})",
                    buffer.ToHexString(), opcode);
                return;
            }
        }
        catch (Exception ex)
        {
            Log.Warning(ex, "Exception while deserializing request (opcode {opcode}): {hexPacket}",
                opcode, buffer.ToHexString());
            return;
        }

        // Check that the deserializer consumed all of the data
        if (reader.Remaining > 0)
            Log.Warning("Packet {packet} has unread data: {rawData}",
                request.ToString(), reader.ReadBytes(reader.Remaining).ToHexString());

        Log.Debug("Incoming packet: {packet}", request.ToString());

        try
        {
            _requestDispatcher.Handle(opcode, request, Player);
        }
        catch (ClientException ex)
        {
            Log.Warning(ex, "Client exception while handling request (opcode {opcode}): {request}",
                opcode, request);
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Exception while handling request (opcode {opcode}): {request}",
                opcode, request);
        }
    }
}