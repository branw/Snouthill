using Snouthill.Db;
using Snouthill.Db.Models;
using Snouthill.Game;
using Snouthill.Net.Packets.Account.Purse;

namespace Snouthill.Net.Packets.Inbound;

[RequestOpcode(8)]
public record GetCredits : IRequest;

public class GetCreditsHandler : IRequestHandler<GetCredits>
{
    public void Handle(GetCredits request, Player player)
    {
        PlayerModel? playerModel;
        using (var db = new DatabaseContext())
        {
            playerModel = db.Players.Find(player.Name);
            if (playerModel == null) return;
        }

        player.Send(new CreditBalance(playerModel));
    }
}