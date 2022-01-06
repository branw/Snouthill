using Serilog;
using Snouthill.Game;

namespace Snouthill.Net.Packets.Catalog;

[RequestOpcode(102)] // "GCAP"
public record GetCatalogPageRequest(
    string PageName) : IRequest;

public class GetCatalogPageRequestDeserialize : IRequestDeserializer<GetCatalogPageRequest>
{
    public GetCatalogPageRequest Deserialize(PacketReader reader)
    {
        var contents = reader.ReadRawString();
        Log.Debug("GetCatalogPageRequest: {contents}", contents);

        var pageName = contents.Split("/")[1];

        return new GetCatalogPageRequest(pageName);
    }
}

public record GetCatalogPageRequestHandler(ICatalogManager CatalogManager) : IRequestHandler<GetCatalogPageRequest>
{
    public void Handle(GetCatalogPageRequest request, Player player)
    {
        var page = CatalogManager.Pages.FirstOrDefault(p => p.Name == request.PageName);
        if (page == null) return;

        var items = CatalogManager.Items
            .Where(item => !item.IsHidden && item.PageIds.Contains(page.Id))
            .ToList();

        player.Send(new CatalogPageResponse(page, items));
    }
}