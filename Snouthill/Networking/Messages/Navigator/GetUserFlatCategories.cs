using Snouthill.Database;
using Snouthill.Database.Models;
using Snouthill.Networking.Messages.Outbound;

namespace Snouthill.Networking.Messages.Navigator;

[Opcode(151)] // "GETUSERFLATCATS"
public record GetUserFlatCategories : IInboundMessage<GetUserFlatCategories>
{
    public static GetUserFlatCategories Deserialize(PacketReader reader) => new();

    public void Handle(Client client)
    {
        if (client.Player == null) throw new PlayerNotAuthenticatedException();

        List<RoomCategoryModel> categoryModels;
        using (var db = new DatabaseContext())
        {
            categoryModels = db.RoomCategories
                .Where(rc => !rc.PublicSpaces)
                .ToList();
        }

        client.Send(new UserFlatCategories(categoryModels));
    }
}