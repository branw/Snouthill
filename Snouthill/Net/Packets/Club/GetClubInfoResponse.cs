namespace Snouthill.Net.Packets.Club;

public record GetClubInfoResponse(
    int DaysRemainingThisMonth,
    int ElapsedMonths,
    int PrepaidMonths,
    GetClubInfoResponse.StatusType Status) : IResponse
{
    public enum StatusType
    {
        Active = 1, // Status bar update only
        JustJoined = 2, // HC window
        Expired = 3 // HC window with "Your Habbo Club membership has expired" message
    }

    public short Opcode => 7;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteString("club_habbo");
        writer.WriteInt(DaysRemainingThisMonth);
        writer.WriteInt(ElapsedMonths);
        writer.WriteInt(PrepaidMonths);
        writer.WriteInt((int) Status);
    }
}