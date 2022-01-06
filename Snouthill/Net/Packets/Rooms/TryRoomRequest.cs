using Snouthill.Game;

namespace Snouthill.Net.Packets.Rooms;

[RequestOpcode(57)]
public record TryRoomRequest(
    int RoomId,
    string? Password) : IRequest;

public record TryRoomRequestDeserializer : IRequestDeserializer<TryRoomRequest>
{
    public TryRoomRequest Deserialize(PacketReader reader)
    {
        var contents = reader.ReadRawString().Split("/");

        var roomId = int.Parse(contents[0]);
        var password = contents.Length > 1 ? contents[1] : null;

        return new TryRoomRequest(roomId, password);
    }
}

public record TryRoomRequestHandler(IRoomManager RoomManager) : IRequestHandler<TryRoomRequest>
{
    public void Handle(TryRoomRequest request, Player player)
    {
        var room = RoomManager.GetRoom(request.RoomId);
        if (room == null) return;

        //TODO handle locked rooms

        player.Send(new LetInRoom());
    }
}