using Snouthill.Db.Models;
using Snouthill.Game;
using Snouthill.Net.Packets.Outbound;

namespace Snouthill.Net.Packets.Account;

[RequestOpcode(7)]
public record GetInfo : IRequest;

public class GetInfoHandler : IRequestHandler<GetInfo>
{
    public void Handle(GetInfo request, Player player)
    {
        if (player.Name == null) return;

        var playerModel = PlayerModel.FindByName(player.Name);
        if (playerModel == null) return;

        player.Send(new UserObject(playerModel));
    }
}