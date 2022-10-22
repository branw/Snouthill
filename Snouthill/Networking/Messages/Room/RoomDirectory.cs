using Serilog;

namespace Snouthill.Networking.Messages.Room;

[Opcode(2)] // "ROOM_DIRECTORY"
public record RoomDirectory(
    int? RoomId) : IInboundMessage<RoomDirectory>
{
    public static RoomDirectory Deserialize(PacketReader reader)
    {
        var isPublicRoom = reader.ReadBytes(1)[0] != 'A';
        if (isPublicRoom) return new RoomDirectory(RoomId: null);

        var roomId = reader.ReadInt();

        return new RoomDirectory(roomId);
    }

    public void Handle(Client client)
    {
        if (client.Player == null) throw new PlayerNotAuthenticatedException();

        // Public room
        if (RoomId == null)
        {
            client.Player.Send(new OpenConnection());
            return;
        }

        var room = client.Server.Rooms.GetRoom(RoomId.Value);
        if (room == null)
        {
            Log.Error("Failed to load room {RoomId}", RoomId);
            return;
        }

        room.AddEntity(client.Player);
    }
}