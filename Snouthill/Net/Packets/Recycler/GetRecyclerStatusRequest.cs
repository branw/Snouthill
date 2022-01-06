using Snouthill.Game;

namespace Snouthill.Net.Packets.Recycler;

[RequestOpcode(223)]
public record GetRecyclerStatusRequest : IRequest;

public class GetRecyclerStatusRequestHandler : IRequestHandler<GetRecyclerStatusRequest>
{
    public void Handle(GetRecyclerStatusRequest gameManager, Player player)
    {
        player.Send(new GetRecyclerStatusResponse(false));
    }
}