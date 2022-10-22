using System.Collections.Immutable;

namespace Snouthill.Game;

public record EntityInfo(
    int InstanceId,
    int? EntityId,
    string Name,
    string Figure,
    (int X, int Y, double Z) Position,
    int HeadRotation,
    int BodyRotation,
    string Sex,
    string? Motto,
    string? Badge,
    string? PoolFigure,
    IEnumerable<(EntityStatus Status, string? Value)> Statuses)
{
    public EntityInfo(AEntity entity) : this(FromEntity(entity))
    {
    }

    private static EntityInfo FromEntity(AEntity entity)
    {
        var statuses = entity.Statuses.Select(s => (s.Key, s.Value));
        return entity switch
        {
            Player player => new EntityInfo(
                player.EntityId,
                player.EntityId,
                player.Name,
                player.Model.Figure,
                player.Position,
                0, //TODO
                0,
                player.Model.Sex,
                player.Model.Motto,
                player.Model.CurrentBadge,
                null,
                statuses),
            _ => throw new InvalidOperationException("Unknown entity")
        };
    }
}