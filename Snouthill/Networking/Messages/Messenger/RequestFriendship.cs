namespace Snouthill.Networking.Messages.Messenger;

[Opcode(39)] // "MESSENGER_REQUESTBUDDY"
public record RequestFriendship : IInboundMessage<RequestFriendship>
{
    public static RequestFriendship Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}