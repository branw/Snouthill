using Serilog;
using Snouthill.Db;
using Snouthill.Db.Models;
using Snouthill.Net.Packets;
using Snouthill.Net.Packets.Outbound;

namespace Snouthill.Game;

public class Room
{
    private readonly List<AEntity> _entities = new();

    public Room(RoomModel roomModel, RoomLayout layout)
    {
        Id = roomModel.Id;

        Layout = layout;
    }

    public int Id { get; init; }

    public RoomLayout Layout { get; set; }

    public int CurrentVisitors => GetEntities<Player>().Count();

    public IReadOnlyList<AEntity> Entities => _entities;

    public IEnumerable<T> GetEntities<T>() where T : AEntity
    {
        return _entities.OfType<T>();
    }

    public void AddEntity(AEntity entity)
    {
        if (entity.Room == this)
        {
            Log.Error("Tried to re-add entity {entity} to room {roomId}", entity.ToString(), Id);
            return;
        }

        entity.Room?.RemoveEntity(entity);

        _entities.Add(entity);

        entity.Room = this;

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
            Log.Error("Tried to remove non-existent entity {entity} from room", entity.ToString());
            return;
        }

        entity.Room = null;

        if (entity is Player player) RemovePlayer(player);
    }

    private void RemovePlayer(Player player)
    {
        player.Messenger?.UpdateStatus();

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

    public void Send(IResponse packet)
    {
        foreach (var player in GetEntities<Player>()) player.Send(packet);
    }
}