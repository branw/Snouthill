using Snouthill.Db;
using Snouthill.Db.Models;
using Snouthill.Game;
using Snouthill.Net.Packets.Account;

namespace Snouthill.Net.Packets.Inbound;

[RequestOpcode(157)]
public record GetAvailableBadges : IRequest;

public class GetAvailableBadgesHandler : IRequestHandler<GetAvailableBadges>
{
    public void Handle(GetAvailableBadges request, Player player)
    {
        PlayerModel? playerModel;
        IEnumerable<BadgeModel> badgeModels;
        using (var db = new DatabaseContext())
        {
            playerModel = db.Players.Find(player.Name);
            if (playerModel == null) return;

            badgeModels = db.Badges.Where(bm => bm.OwnerName == player.Name).ToList();
        }

        player.Send(new AvailableBadges(badgeModels, playerModel));
    }
}