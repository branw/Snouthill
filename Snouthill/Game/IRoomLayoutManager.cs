namespace Snouthill.Game;

public interface IRoomLayoutManager : IManager
{
    public IReadOnlyDictionary<string, RoomLayout> RoomLayouts { get; }

    public RoomLayout? GetLayout(string id);
}