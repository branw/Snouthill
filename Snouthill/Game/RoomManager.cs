using Serilog;
using Snouthill.Db;
using Snouthill.Db.Models;

namespace Snouthill.Game;

public class RoomManager : IRoomManager
{
    private readonly IRoomLayoutManager _roomLayoutManager;
    private readonly Dictionary<int, Room> _rooms = new();

    public RoomManager(IRoomLayoutManager roomLayoutManager)
    {
        _roomLayoutManager = roomLayoutManager;
    }

    public IReadOnlyDictionary<int, Room> Rooms => _rooms;

    public void AddRoom(Room room)
    {
        if (!_rooms.TryAdd(room.Id, room)) Log.Error("Tried to add {roomId} to room manager twice", room.Id);
    }

    public void RemoveRoom(Room room)
    {
        if (!_rooms.Remove(room.Id)) Log.Error("Tried to remove non-existent {roomId} from room manager", room.Id);
    }

    public Room? GetRoom(int id)
    {
        return _rooms.TryGetValue(id, out var existingRoom) ? existingRoom : LoadRoom(id);
    }

    private Room? LoadRoom(int id)
    {
        RoomModel? roomModel;
        using (var db = new DatabaseContext())
        {
            roomModel = db.Rooms.Find(id);
            if (roomModel == null) return null;
        }

        var layout = _roomLayoutManager.GetLayout(roomModel.LayoutName);
        if (layout == null)
        {
            Log.Error("Failed to find layout {layoutName} for room {roomId}", roomModel.LayoutName, roomModel.Id);
            return null;
        }

        var room = new Room(roomModel, layout);
        AddRoom(room);
        return room;
    }
}