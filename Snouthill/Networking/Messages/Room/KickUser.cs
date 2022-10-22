namespace Snouthill.Networking.Messages.Room;

[Opcode(95)] // "KICKUSER"
public record KickUser : IInboundMessage<KickUser>
{
    public static KickUser Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}