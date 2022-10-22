using Snouthill.Game;

namespace Snouthill.Networking.Messages.Room;

[Opcode(34)]
public record UserStatuses(
    IEnumerable<EntityInfo> Entities) : IOutboundMessage
{
    public UserStatuses(IEnumerable<AEntity> entities) :
        this(entities.Select(e => new EntityInfo(e)))
    {
    }
    
    public void Serialize(PacketWriter message)
    {
        foreach (var entity in Entities)
        {
            message.WriteRawString($"{entity.InstanceId} ");
            message.WriteRawString($"{entity.Position.X},{entity.Position.Y},{entity.Position.Z},");
            message.WriteRawString($"{entity.HeadRotation},{entity.BodyRotation}/");

            foreach (var (status, value) in entity.Statuses)
            {
                message.WriteRawString(status switch
                {
                    EntityStatus.Move => "mv",
                    EntityStatus.Sit => "sit",
                    EntityStatus.Lay => "lay",
                    EntityStatus.FlatControl => "flatctrl",
                    EntityStatus.Dance => "dance",
                    EntityStatus.Swim => "swim",
                    EntityStatus.CarryItem => "cri",
                    EntityStatus.CarryDrink => "carryd",
                    EntityStatus.CarryFood => "carryf",
                    EntityStatus.UseItem => "usei",
                    EntityStatus.UseDrink => "eat",
                    EntityStatus.UseFood => "drink",
                    EntityStatus.Wave => "wave",
                    EntityStatus.Gesture => "gest",
                    EntityStatus.Talk => "talk",
                    EntityStatus.Sleep => "Sleep",
                    EntityStatus.Trade => "trd",
                    EntityStatus.Sign => "sign",
                    EntityStatus.Dead => "ded",
                    EntityStatus.Jump => "jmp",
                    EntityStatus.PetSleep => "slp",
                    _ => throw new InvalidDataException()
                });
                
                if (value?.Length > 0)
                {
                    message.WriteRawString($" {value}");
                }
                
                message.WriteRawString("/");
            }
            
            message.WriteByte(13);
        }
    }
}