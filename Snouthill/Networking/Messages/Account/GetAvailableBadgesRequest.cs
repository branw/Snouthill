using Snouthill.Database;
using Snouthill.Database.Models;

namespace Snouthill.Networking.Messages.Account;

[Opcode(157)] // "GETAVAILABLEBADGES"
public record GetAvailableBadges : IInboundMessage<GetAvailableBadges>
{
    public static GetAvailableBadges Deserialize(PacketReader reader) => new();

    public void Handle(Client client)
    {
        if (client.Player == null) throw new PlayerNotAuthenticatedException();

        IEnumerable<BadgeModel> badgeModels;
        using (var db = new DatabaseContext())
        {
            badgeModels = db.Badges.Where(bm => bm.OwnerPlayerId == client.Player.Model.PlayerId).ToList();
        }

        client.Send(new GetAvailableBadgesResponse(badgeModels, client.Player.Model));
    }
}