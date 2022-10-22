namespace Snouthill.Networking.Messages.Catalog;

[Opcode(100)] // "GPRC"
public record Purchase : IInboundMessage<Purchase>
{
    public static Purchase Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}