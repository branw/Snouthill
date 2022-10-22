using System.Collections.Immutable;
using Snouthill.Database;

namespace Snouthill.Game;

public class RoomLayoutManager
{
    public IReadOnlyDictionary<string, RoomLayout> RoomLayouts { get; private set; } =
        new Dictionary<string, RoomLayout>();

    public void Load()
    {
        using var db = new DatabaseContext();
        
        RoomLayouts = db.RoomLayouts
            .ToImmutableDictionary(
                model => model.Id,
                model => new RoomLayout(model));
    }

    public RoomLayout? GetLayout(string id)
    {
        return RoomLayouts.TryGetValue(id, out var roomLayout) ? roomLayout : null;
    }
}