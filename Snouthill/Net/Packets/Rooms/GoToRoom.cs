using Snouthill.Game;

namespace Snouthill.Net.Packets.Rooms;

[RequestOpcode(59)]
public record GoToRoom(
    string RoomId) : IRequest;

public class GoToRoomDeserializer : IRequestDeserializer<GoToRoom>
{
    public GoToRoom Deserialize(PacketReader reader)
    {
        var roomId = reader.ReadRawString();

        return new GoToRoom(roomId);
    }
}

public record GoToRoomHandler(IRoomManager RoomManager) : IRequestHandler<GoToRoom>
{
    public void Handle(GoToRoom request, Player player)
    {
        var id = int.Parse(request.RoomId);

        var room = RoomManager.GetRoom(id);
        if (room == null) return;

        room.AddEntity(player);
    }
}