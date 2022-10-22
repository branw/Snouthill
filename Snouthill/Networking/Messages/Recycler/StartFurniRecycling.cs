namespace Snouthill.Networking.Messages.Recycler;

[Opcode(225)] // "START_FURNI_RECYCLING"
public record StartFurniRecycling : IInboundMessage<StartFurniRecycling>
{
    public static StartFurniRecycling Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}