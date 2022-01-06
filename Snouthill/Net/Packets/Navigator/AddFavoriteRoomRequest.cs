namespace Snouthill.Net.Packets.Navigator;

[RequestOpcode(19)]
public record AddFavoriteRoomRequest(
    int RoomType,
    int RoomId) : IRequest;

public class AddFavoriteRoomRequestDeserializer : IRequestDeserializer<AddFavoriteRoomRequest>
{
    public AddFavoriteRoomRequest Deserialize(PacketReader reader)
    {
        var roomType = reader.ReadInt();
        var roomId = reader.ReadInt();

        return new AddFavoriteRoomRequest(roomType, roomId);
    }
}