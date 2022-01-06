using Serilog;
using Snouthill.Db;
using Snouthill.Db.Models;
using Snouthill.Game;
using Snouthill.Net.Packets.Outbound;

namespace Snouthill.Net.Packets.Inbound;

[RequestOpcode(29)]
public record CreateFlat(
    string FloorSetting,
    string Name,
    string Model,
    string Access,
    string ShowOwnerName) : IRequest;

public class CreateFlatDeserializer : IRequestDeserializer<CreateFlat>
{
    public CreateFlat Deserialize(PacketReader reader)
    {
        var data = reader.ReadRawString().Split("/");

        Log.Debug("CreateFlat: {data}", string.Join("/", data));

        var floorSetting = data[1];
        var roomName = data[2];
        var roomModel = data[3];
        var roomAccess = data[4];
        var showOwnerName = data[5];

        return new CreateFlat(floorSetting, roomName, roomModel, roomAccess, showOwnerName);
    }
}

public class CreateFlatHandler : IRequestHandler<CreateFlat>
{
    public void Handle(CreateFlat request, Player player)
    {
        RequestValidator.VerifyPlayerAuthenticated(player);
        RequestValidator.VerifyPlayerInRoom(player);

        int roomId;
        using (var db = new DatabaseContext())
        {
            var newRoom = db.Rooms.Add(new RoomModel
            {
                OwnerName = player.Name,
                Name = request.Name,
                Description = "",
                LayoutName = request.Model,
                ShowOwnerName = request.ShowOwnerName == "1"
            });
            db.SaveChanges();

            roomId = newRoom.Entity.Id;
        }

        player.Send(new GotoFlat(roomId, request.Name));
    }
}