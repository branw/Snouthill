namespace Snouthill.Net.Packets.Messenger;

public record InitMessengerResponse(
    string PersistentMessage,
    int FriendsLimit,
    int NormalFriendsLimit,
    int ClubFriendsLimit,
    List<string> FriendNames) : IResponse
{
    public short Opcode => 12;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteString(PersistentMessage);
        writer.WriteInt(FriendsLimit);
        writer.WriteInt(NormalFriendsLimit);
        writer.WriteInt(ClubFriendsLimit);

        writer.WriteInt(FriendNames.Count);
        //TODO
    }
}