namespace Snouthill.Networking.Messages.Inbound;

[Opcode(66)] // "FLATPROPBYITEM"
public record FlatPropByItem : IInboundMessage<FlatPropByItem>
{
    public static FlatPropByItem Deserialize(PacketReader reader)
    {
        throw new NotImplementedException();
    }
}