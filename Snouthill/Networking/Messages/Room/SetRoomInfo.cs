using Serilog;

namespace Snouthill.Networking.Messages.Room;

[Opcode(25)] // "SETFLATINFO"
public record SetRoomInfo(
    string Data) : IInboundMessage<SetRoomInfo>
{
    public static SetRoomInfo Deserialize(PacketReader reader)
    {
        var data = reader.ReadRawString();

        Log.Debug("SetRoomInfo: {Data}", data);

        if (data.StartsWith("/")) data = data[1..];

        return new SetRoomInfo(data);
    }
}