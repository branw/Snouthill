namespace Snouthill.Networking.Messages.Navigator;

[Opcode(155)] // "REMOVEALLRIGHTS"
public record RemoveAllRights : IInboundMessage<RemoveAllRights>
{
    public static RemoveAllRights Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}