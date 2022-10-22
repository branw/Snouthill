namespace Snouthill.Networking.Messages.Messenger;

[Opcode(40)] // "MESSENGER_REMOVEBUDDY"
public record RemoveFriend : IInboundMessage<RemoveFriend>
{
    public static RemoveFriend Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}