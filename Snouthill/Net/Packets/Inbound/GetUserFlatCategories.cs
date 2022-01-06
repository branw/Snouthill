using Snouthill.Db;
using Snouthill.Db.Models;
using Snouthill.Game;
using Snouthill.Net.Packets.Outbound;

namespace Snouthill.Net.Packets.Inbound;

[RequestOpcode(151)]
public record GetUserFlatCategories : IRequest;

public class GetUserFlatCategoriesHandler : IRequestHandler<GetUserFlatCategories>
{
    public void Handle(GetUserFlatCategories request, Player player)
    {
        List<RoomCategoryModel> categoryModels;
        using (var db = new DatabaseContext())
        {
            categoryModels = db.RoomCategories
                .Where(rc => !rc.PublicSpaces)
                .ToList();
        }

        player.Send(new UserFlatCategories(categoryModels));
    }
}