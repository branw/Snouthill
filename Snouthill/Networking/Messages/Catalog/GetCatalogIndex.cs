namespace Snouthill.Networking.Messages.Catalog;

[Opcode(101)] // "GCIX"
public record GetCatalogIndex : IInboundMessage<GetCatalogIndex>
{
    public static GetCatalogIndex Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}