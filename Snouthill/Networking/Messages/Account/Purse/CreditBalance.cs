namespace Snouthill.Networking.Messages.Account.Purse;

[Opcode(6)] // [[#catalogue_handler, #handle_purse]]
public record CreditBalance(
    string Balance) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        message.WriteString(Balance);
    }
}