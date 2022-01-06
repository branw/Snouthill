using Snouthill.Db;
using Snouthill.Db.Models;
using Snouthill.Game;

namespace Snouthill.Net.Packets.Account;

[RequestOpcode(228)]
public record GetAccountPreferencesRequest : IRequest;

public class GetAccountPreferencesRequestHandler : IRequestHandler<GetAccountPreferencesRequest>
{
    public void Handle(GetAccountPreferencesRequest request, Player player)
    {
        PlayerModel? playerModel;
        using (var db = new DatabaseContext())
        {
            playerModel = db.Players.Find(player.Name);
            if (playerModel == null) return;
        }

        player.Send(new GetAccountPreferencesResponse(playerModel));
    }
}