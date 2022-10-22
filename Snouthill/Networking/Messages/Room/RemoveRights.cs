namespace Snouthill.Networking.Messages.Room;

[Opcode(97)] // "REMOVERIGHTS"
public record RemoveRights : IInboundMessage<RemoveRights>
{
    public static RemoveRights Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}