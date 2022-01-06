namespace Snouthill.Net.Packets.Rooms;

[RequestOpcode(152)]
public record GetRoomCategoryRequest(
    int RoomId) : IRequest;

public class GetRoomCategoryRequestDeserialize : IRequestDeserializer<GetRoomCategoryRequest>
{
    public GetRoomCategoryRequest Deserialize(PacketReader reader)
    {
        var roomId = reader.ReadInt();

        return new GetRoomCategoryRequest(roomId);
    }
}