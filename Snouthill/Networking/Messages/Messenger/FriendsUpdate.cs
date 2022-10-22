namespace Snouthill.Networking.Messages.Messenger;

[Opcode(13)]
public record FriendsUpdate(
    IEnumerable<FriendInfo> Friends) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        message.WriteInt(Friends.Count());
        foreach (var friend in Friends)
        {
            message.WriteInt(friend.PlayerId);
            message.WriteString(friend.Motto);
            message.WriteBool(friend.IsOnline);
            message.WriteString(friend.CurrentLocation);
        }
    }
}