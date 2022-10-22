namespace Snouthill.Networking.Messages.Messenger;

[Opcode(38)] // "MESSENGER_DECLINEBUDDY"
public record DeclineFriendRequest : IInboundMessage<DeclineFriendRequest>
{
    public static DeclineFriendRequest Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}