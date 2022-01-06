namespace Snouthill.Game;

public interface IPlayerManager : IManager
{
    public IEnumerable<Player> Players { get; }

    public void AddPlayer(Player player);

    public void RemovePlayer(Player player);
}