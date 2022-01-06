using Serilog;
using Snouthill.Game;

namespace Snouthill.Net.Packets.Rooms;

[RequestOpcode(60)]
public record GetHeightMapRequest : IRequest;

public class GetHeightMapRequestHandler : IRequestHandler<GetHeightMapRequest>
{
    public void Handle(GetHeightMapRequest request, Player player)
    {
        if (player.Room == null)
        {
            Log.Error("Player {playerName} requested a heightmap without being in a room", player.Name);
            return;
        }

        player.Send(new GetHeightMapResponse(player.Room.Layout.HeightMap));
    }
}