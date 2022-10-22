namespace Snouthill.Networking.Messages.Recycler;

[Opcode(226)] // "CONFIRM_FURNI_RECYCLING"
public record ConfirmFurniRecycling : IInboundMessage<ConfirmFurniRecycling>
{
    public static ConfirmFurniRecycling Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}