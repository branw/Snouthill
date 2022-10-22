using System.Buffers;
using Newtonsoft.Json;
using Serilog;
using Snouthill.Game;
using Snouthill.Networking.Messages;
using Snouthill.Util;
using JsonConverter = System.Text.Json.Serialization.JsonConverter;

namespace Snouthill.Networking;

public class Client
{
    public readonly Server Server;
    public readonly Connection Connection;

    public Player? Player { get; set; }
    
    public Client(Server server, Connection connection)
    {
        Server = server;
        Connection = connection;
        Connection.OnDataReceived += ProcessPackets;
    }

    private void ProcessPackets(ref ReadOnlySequence<byte> buffer)
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

    private static string PrintMessage<TMessage>(TMessage message) where TMessage : notnull =>
        $"{message.GetType().Name} {JsonConvert.SerializeObject(message)}";

    private void ProcessPacket(ReadOnlySpan<byte> buffer)
    {
        PacketReader reader = new(buffer);
        var opcode = reader.ReadBase64Short();

        IHandleableMessage? message;
        try
        {
            message = OpcodeManager.Deserialize(opcode, reader);
            if (message == null)
            {
                Log.Warning("Unknown packet (opcode {Opcode}): {HexPacket}",
                    opcode, buffer.ToHexString());
                return;
            }
        }
        catch (Exception ex)
        {
            Log.Warning(ex, "Exception while deserializing request: {HexPacket}",
                buffer.ToHexString());
            return;
        }

        // Check that the deserializer consumed all of the data
        if (reader.Remaining > 0)
            Log.Warning("Packet {Packet} has {Length} unread bytes: {RawData}",
                message.ToString(), reader.Remaining, reader.ReadBytes(reader.Remaining).ToHexString());

        Log.Debug("From\t#{ClientId}:\t{Message:l}", Connection.Id, PrintMessage(message));

        try
        {
            message.Handle(this);
        }
        catch (ClientException ex)
        {
            Log.Warning(ex, "Client exception while handling {Message} for {Client}", message, this);
        }
        catch (Exception ex)
        {
            Log.Error(ex, "Exception while handling {Message} for {Client}", message, this);
        }
    }

    public void Send(IOutboundMessage message)
    {
        Log.Debug("To\t#{ClientId}:\t{Message:l}",  Connection.Id, PrintMessage(message));

        var opcode = OpcodeManager.GetOpcode(message);
        if (opcode == null)
            throw new InvalidOperationException();

        PacketWriter writer = new();
        writer.WriteOpcode((short) opcode);
        message.Serialize(writer);
        writer.WriteEndOfPacket();

        Connection.Send(writer.ToArray());
    }

    public override string ToString()
    {
        return $"Client {Connection.Id} ({Connection.EndPoint})";
    }
}