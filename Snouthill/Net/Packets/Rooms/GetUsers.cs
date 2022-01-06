using Serilog;
using Snouthill.Game;

namespace Snouthill.Net.Packets.Rooms;

[RequestOpcode(61)]
public record GetUsers : IRequest;

public record GetUsersHandler : IRequestHandler<GetUsers>
{
    public void Handle(GetUsers request, Player player)
    {
        if (player.Room == null)
        {
            Log.Error("Player {playerName} sent a room request from outside of a room", player.Name);
            return;
        }

        player.Send(new ObjectsWorld(new List<Item>()));
        player.Send(new ActiveObjects(new List<Item>()));

        player.Messenger?.UpdateStatus();
    }
}