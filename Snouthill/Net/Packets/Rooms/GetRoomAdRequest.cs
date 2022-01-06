using Snouthill.Game;

namespace Snouthill.Net.Packets.Rooms;

[RequestOpcode(126)]
public record GetRoomAdRequest : IRequest;

public class GetRoomAdRequestHandler : IRequestHandler<GetRoomAdRequest>
{
    public void Handle(GetRoomAdRequest request, Player player)
    {
        player.Send(new GetRoomAdResponse());
    }
}