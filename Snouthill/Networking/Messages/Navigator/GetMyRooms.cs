using Snouthill.Database;
using Snouthill.Database.Models;
using Snouthill.Networking.Messages.Room;

namespace Snouthill.Networking.Messages.Navigator;

[Opcode(16)] // "SUSERF"
public record GetMyRooms(
    string Name) : IInboundMessage<GetMyRooms>
{
    public static GetMyRooms Deserialize(PacketReader reader)
    {
        var name = reader.ReadRawString();

        return new GetMyRooms(name);
    }

    public void Handle(Client client)
    {
        if (client.Player == null) throw new PlayerNotAuthenticatedException();

        List<RoomModel> roomModels;
        using (var db = new DatabaseContext())
        {
            roomModels = db.Rooms.Where(rm => rm.OwnerName == client.Player.Name).ToList();
        }

        if (roomModels.Count > 0)
            client.Send(new RoomResults(roomModels));
        else
            client.Send(new NoRoomsForUser(client.Player.Name));
    }
}