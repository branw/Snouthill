namespace Snouthill.Networking.Messages.Login;

// Model with title "Alert_YouAreBanned_T=A Moderator kicked you out of the room." and message prefixed by
// "Alert_YouAreBanned=You have been banned for breaking the Habbo Way. This is why (if no ban reason is shown use the
// Contact Us form):"
[Opcode(35)] // hh_entry/Login Handler/handleUserBanned
public record UserBannedResponse(
    string Message) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        message.WriteRawString(Message);
    }
}