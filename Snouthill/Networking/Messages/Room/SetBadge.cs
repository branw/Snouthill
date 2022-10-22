namespace Snouthill.Networking.Messages.Room;

[Opcode(158)] // "SETBADGE"
public record SetBadge : IInboundMessage<SetBadge>
{
    public static SetBadge Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}