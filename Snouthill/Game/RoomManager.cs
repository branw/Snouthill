using Serilog;
using Snouthill.Database;
using Snouthill.Database.Models;

namespace Snouthill.Game;

public class RoomManager
{
    private readonly RoomLayoutManager _roomLayouts = new();
    private readonly Dictionary<int, Room> _rooms = new();

    public IReadOnlyDictionary<int, Room> Rooms => _rooms;

    public void Load()
    {
        _roomLayouts.Load();
    }

    private void AddRoom(Room room)
    {
        if (!_rooms.TryAdd(room.Id, room)) 
            Log.Error("Tried to add {RoomId} to room manager twice", room.Id);
    }

    public void RemoveRoom(Room room)
    {
        if (!_rooms.Remove(room.Id)) 
            Log.Error("Tried to remove non-existent {RoomId} from room manager", room.Id);
    }

    public Room? GetRoom(int id)
    {
        return _rooms.TryGetValue(id, out var existingRoom) ? existingRoom : LoadRoom(id);
    }

    public Room? LoadRoom(int id)
    {
        RoomModel? roomModel;
        using (var db = new DatabaseContext())
        {
            roomModel = db.Rooms.Find(id);
            if (roomModel == null) return null;
        }

        var layout = _roomLayouts.GetLayout(roomModel.LayoutName);
        if (layout == null)
        {
            Log.Error("Failed to find layout {LayoutName} for room {RoomId}", roomModel.LayoutName, roomModel.Id);
            return null;
        }

        var room = new Room(roomModel, layout);
        AddRoom(room);
        return room;
    }
}