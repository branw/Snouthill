using Snouthill.Game;

namespace Snouthill.Net.Packets.Catalog;

[RequestOpcode(215)]
public record GetAliasListRequest : IRequest;

public class GetAliasListRequestHandler : IRequestHandler<GetAliasListRequest>
{
    public void Handle(GetAliasListRequest request, Player player)
    {
        player.Send(new SpriteListResponse());
        player.Send(new AliasToggleResponse());
    }
}