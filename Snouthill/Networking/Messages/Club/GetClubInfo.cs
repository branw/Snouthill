namespace Snouthill.Networking.Messages.Club;

// hh_club/Club Handler
[Opcode(26)] // "SCR_GET_USER_INFO" 
public record GetClubInfo(
    string ClubName) : IInboundMessage<GetClubInfo>
{
    public static GetClubInfo Deserialize(PacketReader reader)
    {
        // Only possible value is "club_habbo"
        var clubName = reader.ReadString();

        return new GetClubInfo(clubName);
    }

    public void Handle(Client client)
    {
        // PlayerModel playerModel;
        // using (var db = new DatabaseContext())
        // {
        //     playerModel = db.Players.Find(Player.Name)!;
        // }

        if (true) //new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds() < playerModel.ClubExpiration)
            client.Send(new ClubInfo("club_habbo", 25, 8, 2, ClubInfo.StatusType.Active));
    }
}