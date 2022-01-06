namespace Snouthill.Net.Packets.Rooms;

[RequestOpcode(261)]
public record RateRoomRequest(
    int Vote) : IRequest;

public class RateRoomRequestDeserializer : IRequestDeserializer<RateRoomRequest>
{
    public RateRoomRequest Deserialize(PacketReader reader)
    {
        var vote = reader.ReadInt();

        return new RateRoomRequest(vote);
    }
}