using Snouthill.Game;

namespace Snouthill.Net.Packets.Recycler;

[RequestOpcode(222)]
public record GetRecyclerConfigRequest : IRequest;

public class GetRecyclerConfigRequestHandler : IRequestHandler<GetRecyclerConfigRequest>
{
    public void Handle(GetRecyclerConfigRequest request, Player player)
    {
        player.Send(new GetRecyclerConfigResponse(false, new List<string>(), 0, 0, 0));
    }
}