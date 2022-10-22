namespace Snouthill.Networking.Messages.Recycler;

[Opcode(224)] // "APPROVE_RECYCLED_FURNI"
public record ApproveRecycledFurni : IInboundMessage<ApproveRecycledFurni>
{
    public static ApproveRecycledFurni Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}