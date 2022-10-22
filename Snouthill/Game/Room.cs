using Serilog;
using Snouthill.Database;
using Snouthill.Database.Models;
using Snouthill.Networking.Messages;
using Snouthill.Networking.Messages.Room;

namespace Snouthill.Game;

public class Room : IDisposable
{
    private readonly List<AEntity> _entities = new();
    public IReadOnlyList<AEntity> Entities => _entities;

    public Room(RoomModel roomModel, RoomLayout layout)
    {
        Id = roomModel.Id;

        Layout = layout;
    }

    public bool Active { get; internal set; } = false;
    
    public int Id { get; init; }
    public RoomLayout Layout { get; set; }
    public bool IsPublic { get; set; }
    public bool IsClubOnly { get; set; } = false;
    
    public int CurrentVisitors => GetEntities<Player>().Count();

    public void Dispose()
    {
        if (!Active)
            return;
        
        
    }
    
    public IEnumerable<T> GetEntities<T>() where T : AEntity
    {
        return _entities.OfType<T>();
    }

    // private static List<Item> GetPublicItems(int roomId, string layoutId)
    // {
    //     List<PublicItemModel> models;
    //     using (var db = new DatabaseContext())
    //     {
    //         
    //     }
    //     
    //     
    // }
    
    private void Initialize()
    {
        if (IsPublic)
        {
            
        }
        
    }

    public void AddEntity(AEntity entity)
    {
        if (entity.Room == this)
        {
            Log.Error("Tried to re-add entity {Entity} to room {RoomId}", entity.ToString(), Id);
            return;
        }

        entity.Room?.RemoveEntity(entity);

        _entities.Add(entity);

        entity.Room = this;
        entity.Position = Layout.DoorPosition;

        if (entity is Player player) AddPlayer(player);
    }

    private void AddPlayer(Player player)
    {
        PersistVisitorCount();

        player.Send(new RoomUrl());
        player.Send(new RoomReady(Id, Layout.Name));
    }

    public void RemoveEntity(AEntity entity)
    {
        if (!_entities.Remove(entity))
        {
            Log.Error("Tried to remove non-existent entity {Entity} from room", entity.ToString());
            return;
        }

        entity.Room = null;

        if (entity is Player player) RemovePlayer(player);
    }

    private void RemovePlayer(Player player)
    {
        player.Messenger.UpdateStatus();

        PersistVisitorCount();
    }

    private void PersistVisitorCount()
    {
        using var db = new DatabaseContext();

        var roomModel = db.Rooms.Find(Id);
        if (roomModel == null) return;

        roomModel.CurrentVisitors = CurrentVisitors;
        db.SaveChanges();
    }

    public void Send(IOutboundMessage packet, params Player[] except)
    {
        foreach (var player in GetEntities<Player>().Except(except))
            player.Send(packet);
    }
}