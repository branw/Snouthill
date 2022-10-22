namespace Snouthill.Networking.Messages.Login;

[Opcode(287)] // hh_entry/Login Handler/handleHotelLogout
public record Logout(
    Logout.ReasonType Reason) : IOutboundMessage
{
    public enum ReasonType
    {
        // Just disconnect
        Disconnect = -1,
        // Open URL "url_logged_out"
        LoggedOut = 1,
        // Open URL "url_logout_concurrent"
        LogOutConcurrent = 2,
        // Open URL "url_logout_timeout"
        LogOutTimeOut = 3
    }

    public void Serialize(PacketWriter message)
    {
        message.WriteInt((int) Reason);
    }
}