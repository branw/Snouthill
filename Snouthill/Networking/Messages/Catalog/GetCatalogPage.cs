namespace Snouthill.Networking.Messages.Catalog;

[Opcode(102)] // "GCAP"
public record GetCatalogPage : IInboundMessage<GetCatalogPage>
{
    public static GetCatalogPage Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}