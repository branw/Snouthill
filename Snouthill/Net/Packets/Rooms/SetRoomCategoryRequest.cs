namespace Snouthill.Net.Packets.Rooms;

[RequestOpcode(153)]
public record SetRoomCategoryRequest(
    int RoomId,
    int CategoryId) : IRequest;

public class SetRoomCategoryRequestDeserializer : IRequestDeserializer<SetRoomCategoryRequest>
{
    public SetRoomCategoryRequest Deserialize(PacketReader reader)
    {
        var roomId = reader.ReadInt();
        var categoryId = reader.ReadInt();

        return new SetRoomCategoryRequest(roomId, categoryId);
    }
}