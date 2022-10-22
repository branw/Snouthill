namespace Snouthill.Networking.Messages.Login.Registration;

[Opcode(49)] // [[#getServerDate, #handle_date]]
public record ServerDate(
    string ShortDate) : IOutboundMessage
{
    public static ServerDate Now => new(DateTime.Now.ToShortDateString());

    public void Serialize(PacketWriter message)
    {
        message.WriteString(ShortDate);
    }
}