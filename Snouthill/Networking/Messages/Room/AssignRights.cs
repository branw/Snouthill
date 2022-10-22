namespace Snouthill.Networking.Messages.Room;

[Opcode(96)] // "ASSIGNRIGHTS"
public record AssignRights : IInboundMessage<AssignRights>
{
    public static AssignRights Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}