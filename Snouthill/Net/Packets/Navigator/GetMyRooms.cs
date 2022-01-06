using Snouthill.Db;
using Snouthill.Db.Models;
using Snouthill.Game;
using Snouthill.Net.Packets.Outbound;

namespace Snouthill.Net.Packets.Navigator;

[RequestOpcode(16)]
public record GetMyRooms : IRequest;

public class GetMyRoomsHandler : IRequestHandler<GetMyRooms>
{
    public void Handle(GetMyRooms request, Player player)
    {
        RequestValidator.VerifyPlayerAuthenticated(player);

        List<RoomModel> roomModels;
        using (var db = new DatabaseContext())
        {
            roomModels = db.Rooms.Where(rm => rm.OwnerName == player.Name).ToList();
        }

        if (roomModels.Count > 0)
            player.Send(new RoomResults(roomModels));
        else
            player.Send(new NoRoomsForUser(player.Name!));
    }
}