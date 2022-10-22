using Serilog;

namespace Snouthill.Game;

public class PlayerManager
{
    private readonly List<Player> _players = new();
    public IEnumerable<Player> Players => _players;

    public void Load()
    {
    }

    public void AddPlayer(Player player)
    {
        _players.Add(player);
    }

    public void RemovePlayer(Player player)
    {
        if (!_players.Remove(player)) 
            Log.Error("Tried to remove non-existent {Name} from player manager", player.Name);
    }
}