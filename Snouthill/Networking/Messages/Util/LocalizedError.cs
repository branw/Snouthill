namespace Snouthill.Networking.Messages.Util;

[Opcode(33)] // [[#roomkiosk_handler, #room_handler, #navigator_handler, #login_handler], #handleErr]
public record LocalizedError(
    string Message) : IOutboundMessage
{
    // Model with "Alert_WrongNameOrPassword=Wrong name or password - please try again!". Sending a second time
    // will open the URL "login_forgottenPassword_url=https://www.habbo.co.uk/account/password/forgot".
    public static readonly LocalizedError IncorrectPassword = new("login incorrect");

    // Modal with "alert_old_client=You have an old version cached. Please empty your browser cache and login again."
    public static readonly LocalizedError IncorrectVersion = new("Version not correct");

    // Modal with "alert_duplicatesession=You are already logged in on another hotel! Log out before trying again.",
    // also ending the current connection.
    public static readonly LocalizedError DuplicateSession = new("Duplicate session");

    public void Serialize(PacketWriter message)
    {
        message.WriteString(Message);
    }

    // Modal with custom message and title "alert_warning=Moderator says:"
    public static LocalizedError ModSays(string message)
    {
        return new($"mod_warn/{message}");
    }
}