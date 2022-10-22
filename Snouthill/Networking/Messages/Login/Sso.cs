namespace Snouthill.Networking.Messages.Login;

[Opcode(204)] // "SSO"
public record Sso(
    string Ticket) : IInboundMessage<Sso>
{
    public static Sso Deserialize(PacketReader reader)
    {
        var ticket = reader.ReadString();

        return new Sso(ticket);
    }
}