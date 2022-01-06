namespace Snouthill.Game;

public interface IRoomManager : IManager
{
    public IReadOnlyDictionary<int, Room> Rooms { get; }

    public void AddRoom(Room room);

    public void RemoveRoom(Room room);

    public Room? GetRoom(int id);
}