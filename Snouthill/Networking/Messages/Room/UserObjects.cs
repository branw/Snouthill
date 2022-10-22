using Snouthill.Game;

namespace Snouthill.Networking.Messages.Room;

[Opcode(28)] // [[#room_handler, #handle_users]]
public record UserObjects(
    IEnumerable<EntityInfo> Entities) : IOutboundMessage
{
    public UserObjects(IEnumerable<AEntity> entities) :
        this(entities.Select(e => new EntityInfo(e)))
    {
    }
    
    public void Serialize(PacketWriter message)
    {
        foreach (var entity in Entities)
        {
            message.WriteRawString("\r");
            
            message.WritePair("i", entity.InstanceId.ToString());
            if (entity.EntityId != null) message.WritePair("a", entity.EntityId.ToString()!);
            message.WritePair("n", entity.Name);
            message.WritePair("f", entity.Figure);
            message.WritePair("s", entity.Sex);
            message.WritePair("l", $"{entity.Position.X} {entity.Position.Y} {entity.Position.Z}");
            if (entity.Motto is {Length: > 0}) message.WritePair("c", entity.Motto);
            if (entity.Badge != null) message.WritePair("b", entity.Badge);
            if (entity.PoolFigure != null) message.WritePair("p", entity.PoolFigure);
        }
    }
}