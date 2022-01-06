using Serilog;
using Snouthill.Game;

namespace Snouthill.Net.Packets.Rooms;

[RequestOpcode(63)]
public record GetItemsRequest : IRequest;

public class GetItemsRequestHandler : IRequestHandler<GetItemsRequest>
{
    public void Handle(GetItemsRequest request, Player player)
    {
        if (player.Room == null)
        {
            Log.Error("Player {playerName} sent a room request from outside of a room", player.Name);
            return;
        }

        player.Send(new GetItemsResponse(new List<Item>()));
    }
}