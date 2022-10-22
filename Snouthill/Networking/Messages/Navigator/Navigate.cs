using System.Linq;
using Snouthill.Database;

namespace Snouthill.Networking.Messages.Navigator;

[Opcode(150)] // "NAVIGATE"
public record Navigate(
    bool HideFullRooms,
    int Category) : IInboundMessage<Navigate>
{
    public static Navigate Deserialize(PacketReader reader)
    {
        var hideFullRooms = reader.ReadInt() == 1;
        var category = reader.ReadInt();

        return new Navigate(hideFullRooms, category);
    }

    public void Handle(Client client)
    {
        if (client.Player == null) throw new PlayerNotAuthenticatedException();

        using var db = new DatabaseContext();
        var category = db.RoomCategories.Find(Category);
        if (category == null) return;

        List<(int Id, bool IsPublic, string Name, int CurrentVisitors, int MaxVisitors, int CategoryId,
            string Description, int Door, string FileNames)> rooms;

        if (category.PublicSpaces)
        {
            var publicRooms = db.Rooms
                .Where(r => r.Category == category.Id && r.OwnerName == null && !r.HideFromNavigator).ToList();

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
            .Where(rc => rc.ParentCategoryId == Category)
            .AsEnumerable()
            .Select(sc => (sc.Id, sc.Name, CurrentVisitors: 0, MaxVisitors: 10, sc.ParentCategoryId))
            .ToList();

        client.Send(new NavNodeInfo(
            HideFullRooms,
            Category,
            category.PublicSpaces,
            category.Name,
            5,
            10,
            category.ParentCategoryId,
            rooms,
            subcategories));
    }
}