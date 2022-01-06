using Snouthill.Db;
using Snouthill.Db.Models;
using Snouthill.Game;
using Snouthill.Net.Packets.Outbound;

namespace Snouthill.Net.Packets.Inbound;

[RequestOpcode(21)]
public record GetRoomInfo(
    int RoomId) : IRequest;

public class GetRoomInfoDeserializer : IRequestDeserializer<GetRoomInfo>
{
    public GetRoomInfo Deserialize(PacketReader reader)
    {
        var roomId = int.Parse(reader.ReadRawString());

        return new GetRoomInfo(roomId);
    }
}

public class GetRoomInfoHandler : IRequestHandler<GetRoomInfo>
{
    public void Handle(GetRoomInfo request, Player player)
    {
        RoomModel? roomModel;
        using (var db = new DatabaseContext())
        {
            roomModel = db.Rooms.Find(request.RoomId);
            if (roomModel == null) return;
        }

        player.Send(new RoomInfo(roomModel));
    }
}