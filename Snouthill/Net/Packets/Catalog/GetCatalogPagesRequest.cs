using Snouthill.Game;

namespace Snouthill.Net.Packets.Catalog;

[RequestOpcode(101)] // "GCIX"
public record GetCatalogPagesRequest : IRequest;

public record GetCatalogPagesRequestHandler(ICatalogManager CatalogManager) : IRequestHandler<GetCatalogPagesRequest>
{
    public void Handle(GetCatalogPagesRequest request, Player player)
    {
        player.Send(new CatalogPagesResponse(CatalogManager.Pages));
    }
}