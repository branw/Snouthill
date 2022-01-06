using Serilog;

namespace Snouthill.Net.Packets.Rooms;

[RequestOpcode(25)]
public record SetRoomInfo : IRequest;

public class SetRoomInfoDeserializer : IRequestDeserializer<SetRoomInfo>
{
    public SetRoomInfo Deserialize(PacketReader reader)
    {
        var data = reader.ReadRawString();

        Log.Debug("SetRoomInfo: {data}", data);

        if (data.StartsWith("/")) data = data[1..];

        return new SetRoomInfo();
    }
}