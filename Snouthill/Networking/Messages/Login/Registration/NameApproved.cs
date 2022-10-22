namespace Snouthill.Networking.Messages.Login.Registration;

[Opcode(36)] // hh_cat_code::handle_nameapproved
public record NameApproved(
    NameApproved.ReplyType Reply) : IOutboundMessage
{
    public enum ReplyType
    {
        Accepted = 0,
        TooLong = 1,
        TooShort = 2,
        Forbidden = 3,
        AlreadyRegistered = 4
    }

    public void Serialize(PacketWriter message)
    {
        message.WriteInt((int) Reply);
    }
}