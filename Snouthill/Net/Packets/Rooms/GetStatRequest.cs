using Serilog;
using Snouthill.Game;

namespace Snouthill.Net.Packets.Rooms;

[RequestOpcode(64)]
public record GetStatRequest : IRequest;

public class GetStatRequestHandler : IRequestHandler<GetStatRequest>
{
    public void Handle(GetStatRequest request, Player player)
    {
        if (player.Room == null)
        {
            Log.Error("Player {playerName} sent a room request from outside of a room", player.Name);
        }
    }
}