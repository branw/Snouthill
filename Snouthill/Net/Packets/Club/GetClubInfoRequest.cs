using Snouthill.Game;

namespace Snouthill.Net.Packets.Club;

[RequestOpcode(26)]
public record GetClubInfoRequest(
    string ClubName) : IRequest;

public class GetClubInfoRequestDeserializer : IRequestDeserializer<GetClubInfoRequest>
{
    public GetClubInfoRequest Deserialize(PacketReader reader)
    {
        var clubName = reader.ReadString();

        return new GetClubInfoRequest(clubName);
    }
}

public class GetClubInfoRequestHandler : IRequestHandler<GetClubInfoRequest>
{
    public void Handle(GetClubInfoRequest request, Player player)
    {
        // PlayerModel playerModel;
        // using (var db = new DatabaseContext())
        // {
        //     playerModel = db.Players.Find(Player.Name)!;
        // }

        if (true) //new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds() < playerModel.ClubExpiration)
            player.Send(new GetClubInfoResponse(25, 8, 2, GetClubInfoResponse.StatusType.Active));
    }
}