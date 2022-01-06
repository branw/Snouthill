using Serilog;
using Snouthill.Game;
using Snouthill.Net.Packets.Outbound;

namespace Snouthill.Net.Packets.Rooms;

[RequestOpcode(2)]
public record RoomDirectory(
    int? RoomId) : IRequest;

public class RoomDirectoryDeserializer : IRequestDeserializer<RoomDirectory>
{
    public RoomDirectory Deserialize(PacketReader reader)
    {
        var isPrivateRoom = reader.ReadBytes(1)[0] != 'A';
        if (isPrivateRoom) return new RoomDirectory(null);

        var roomId = reader.ReadInt();

        return new RoomDirectory(roomId);
    }
}

public record RoomDirectoryHandler(IRoomManager RoomManager) : IRequestHandler<RoomDirectory>
{
    public void Handle(RoomDirectory request, Player player)
    {
        if (request.RoomId == null)
        {
            player.Send(new OpenConnection());
            return;
        }

        var room = RoomManager.GetRoom(request.RoomId.Value);
        if (room == null)
        {
            Log.Error("Failed to load room {roomId}", request.RoomId);
            return;
        }

        room.AddEntity(player);
    }
}