namespace Snouthill.Networking.Messages.Messenger;

public record FriendRequest(
    int UserId,
    string Name) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        message.WriteInt(UserId);
        message.WriteString(Name);
    }
}