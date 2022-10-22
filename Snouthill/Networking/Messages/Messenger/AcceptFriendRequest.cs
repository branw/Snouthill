namespace Snouthill.Networking.Messages.Messenger;

[Opcode(37)] // "MESSENGER_ACCEPTBUDDY"
public record AcceptFriendRequest : IInboundMessage<AcceptFriendRequest>
{
    public static AcceptFriendRequest Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}