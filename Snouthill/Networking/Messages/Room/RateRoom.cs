namespace Snouthill.Networking.Messages.Room;

[Opcode(261)] // v14+ "RATEFLAT"
public record RateRoom(
    int Vote) : IInboundMessage<RateRoom>
{
    public static RateRoom Deserialize(PacketReader reader)
    {
        var vote = reader.ReadInt();

        return new RateRoom(vote);
    }
}