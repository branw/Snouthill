namespace Snouthill.Networking.Messages.Messenger;

public record FriendInfo(
    int PlayerId,
    string Name,
    bool IsMale,
    string Motto,
    bool IsOnline,
    string CurrentLocation,
    string LastOnline,
    string Figure);

[Opcode(12)] // [[#friend_list_handler, #handleFriendListInit]]
public record InitMessengerResponse(
    string PersistentMessage,
    int FriendsLimit,
    int NormalFriendsLimit,
    int ClubFriendsLimit,
    List<FriendInfo> Friends) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        message.WriteString(PersistentMessage);
        message.WriteInt(FriendsLimit);
        message.WriteInt(NormalFriendsLimit);
        message.WriteInt(ClubFriendsLimit);

        message.WriteInt(Friends.Count);
        foreach (var friend in Friends)
        {
            message.WriteInt(friend.PlayerId);
            message.WriteString(friend.Name);
            message.WriteBool(friend.IsMale);
            message.WriteString(friend.Motto);
            message.WriteBool(friend.IsOnline);
            message.WriteString(friend.CurrentLocation);
            message.WriteString(friend.LastOnline);
            message.WriteString(friend.Figure);
        }
    }
}