namespace Snouthill.Networking.Messages.Room;

[Opcode(87)] // "CARRYITEM"
public record CarryItem : IInboundMessage<CarryItem>
{
    public static CarryItem Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}