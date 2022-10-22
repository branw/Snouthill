namespace Snouthill.Networking.Messages.Navigator;

[Opcode(19)] // "ADD_FAVORITE_ROOM"
public record AddFavoriteRoom(
    int RoomType,
    int RoomId) : IInboundMessage<AddFavoriteRoom>
{
    public static AddFavoriteRoom Deserialize(PacketReader reader)
    {
        var roomType = reader.ReadInt();
        var roomId = reader.ReadInt();

        return new AddFavoriteRoom(roomType, roomId);
    }
}