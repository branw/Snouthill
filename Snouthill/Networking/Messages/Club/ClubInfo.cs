namespace Snouthill.Networking.Messages.Club;

// [Opcode("SCR_SINF", 5)] // hh_club/Club Handler/handle_scr_sinfo
[Opcode(7)] // hh_club/Club Handler/handle_scr_sinfo
public record ClubInfo(
    string ProductName,
    int DaysRemainingThisMonth,
    int ElapsedMonths,
    int PrepaidMonths,
    ClubInfo.StatusType Status) : IOutboundMessage
{
    public enum StatusType
    {
        Active = 1, // Status bar update only
        JustJoined = 2, // HC window
        Expired = 3 // HC window with "Your Habbo Club membership has expired" message
    }

    public void Serialize(PacketWriter message)
    {
        message.WriteString(ProductName);
        message.WriteInt(DaysRemainingThisMonth);
        message.WriteInt(ElapsedMonths);
        message.WriteInt(PrepaidMonths);
        message.WriteInt((int) Status);
    }
}