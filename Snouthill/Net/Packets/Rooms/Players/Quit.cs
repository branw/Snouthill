using Snouthill.Game;

namespace Snouthill.Net.Packets.Rooms.Players;

[RequestOpcode(53)]
public record Quit : IRequest;

public class QuitHandler : IRequestHandler<Quit>
{
    public void Handle(Quit request, Player player)
    {
        player.Room?.RemoveEntity(player);
    }
}