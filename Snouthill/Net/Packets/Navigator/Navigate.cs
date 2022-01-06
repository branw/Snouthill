using Snouthill.Db;
using Snouthill.Game;
using Snouthill.Net.Packets.Outbound;

namespace Snouthill.Net.Packets.Navigator;

[RequestOpcode(150)]
public record Navigate(
    bool HideFullRooms,
    int Category) : IRequest;

public class NavigateDeserializer : IRequestDeserializer<Navigate>
{
    public Navigate Deserialize(PacketReader reader)
    {
        var hideFullRooms = reader.ReadInt() == 1;
        var category = reader.ReadInt();

        return new Navigate(hideFullRooms, category);
    }
}

public class NavigateHandler : IRequestHandler<Navigate>
{
    public void Handle(Navigate request, Player player)
    {
        using var db = new DatabaseContext();
        var category = db.RoomCategories.Find(request.Category);
        if (category == null) return;

        List<(int Id, bool IsPublic, string Name, int CurrentVisitors, int MaxVisitors, int CategoryId,
            string Description, int Door, string FileNames)> rooms;

        if (category.PublicSpaces)
        {
            var publicRooms = db.Rooms
                .Where(r => r.Category == category.Id && r.OwnerName == "").ToList();

            rooms = publicRooms.Select(room => (room.Id, true, room.Name, 0, 10, room.Category,
                room.Description, 0, room.FileNames)).ToList();
        }
        else
        {
            //TODO
            rooms =
                new List<(int Id, bool IsPublic, string Name, int CurrentVisitors, int MaxVisitors, int CategoryId,
                    string Description, int Door, string FileNames)>();
        }

        var subcategories = db.RoomCategories
            .Where(rc => rc.ParentCategoryId == request.Category)
            .AsEnumerable()
            .Select(sc => (sc.Id, sc.Name, CurrentVisitors: 0, MaxVisitors: 10, sc.ParentCategoryId))
            .ToList();

        player.Send(new NavNodeInfo(
            request.HideFullRooms,
            request.Category,
            category.PublicSpaces,
            category.Name,
            5,
            10,
            category.ParentCategoryId,
            rooms,
            subcategories));
    }
}