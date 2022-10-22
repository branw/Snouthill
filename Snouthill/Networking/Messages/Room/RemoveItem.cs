namespace Snouthill.Networking.Messages.Room;

[Opcode(85)] // "REMOVEITEM"
public record RemoveItem : IInboundMessage<RemoveItem>
{
    public static RemoveItem Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}