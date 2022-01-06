using Serilog;
using Snouthill.Game;

namespace Snouthill.Net.Packets.Rooms;

[RequestOpcode(62)]
public record GetObjects : IRequest;

public class GetObjectsHandler : IRequestHandler<GetObjects>
{
    public void Handle(GetObjects request, Player player)
    {
        if (player.Room == null)
        {
            Log.Error("Player {playerName} sent a room request from outside of a room", player.Name);
            return;
        }

        player.Send(new UserObjects(player.Room.Entities));
    }
}