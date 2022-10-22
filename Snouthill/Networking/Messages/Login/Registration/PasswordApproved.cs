namespace Snouthill.Networking.Messages.Login.Registration;

[Opcode(282)] // hh_registrat/handle_password_approved
public record PasswordApproved(
    PasswordApproved.ReplyType Reply) : IOutboundMessage
{
    public enum ReplyType
    {
        Approved = 0,
        TooShort = 1, // "Passwords must be at least 6 characters long."
        TooLong = 2, // "Your password is too long"
        ForbiddenCharacters = 3, // "Only use these characters: 12345..."
        MissingNumber = 4, // "Password must contain at least one number"
        TooSimilarToName = 5 // "Your name and password are too similar"
    }

    public void Serialize(PacketWriter message)
    {
        message.WriteInt((int) Reply);
    }
}