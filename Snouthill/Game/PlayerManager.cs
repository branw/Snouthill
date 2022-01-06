using Serilog;

namespace Snouthill.Game;

public class PlayerManager : IPlayerManager
{
    private readonly List<Player> _players = new();
    public IEnumerable<Player> Players => _players;

    public void AddPlayer(Player player)
    {
        _players.Add(player);
    }

    public void RemovePlayer(Player player)
    {
        if (!_players.Remove(player)) Log.Error("Tried to remove non-existent {name} from player manager", player.Name);
    }
}