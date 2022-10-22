using Serilog;
using Snouthill.Database;
using Snouthill.Database.Models;

namespace Snouthill.Networking.Messages.Room;

[Opcode(29)] // "CREATEFLAT"
public record CreateFlat(
    string FloorSetting,
    string Name,
    string Model,
    string Access,
    string ShowOwnerName) : IInboundMessage<CreateFlat>
{
    public static CreateFlat Deserialize(PacketReader reader)
    {
        var data = reader.ReadRawString().Split("/");

        Log.Debug("CreateFlat: {Data}", string.Join("/", data));

        var floorSetting = data[1];
        var roomName = data[2];
        var roomModel = data[3];
        var roomAccess = data[4];
        var showOwnerName = data[5];

        return new CreateFlat(floorSetting, roomName, roomModel, roomAccess, showOwnerName);
    }

    public void Handle(Client client)
    {
        if (client.Player == null) throw new PlayerNotAuthenticatedException();

        int roomId;
        using (var db = new DatabaseContext())
        {
            var newRoom = db.Rooms.Add(new RoomModel
            {
                OwnerName = client.Player.Name,
                Name = Name,
                Description = "",
                LayoutName = Model,
                ShowOwnerName = ShowOwnerName == "1"
            });
            db.SaveChanges();

            roomId = newRoom.Entity.Id;
        }

        client.Send(new RoomCreated(roomId, Name));
    }
}