namespace Snouthill.Networking.Messages.Account.Purse;

[Opcode(209)] // hh_purse::handle_purse
public record TransactionLog() : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        throw new NotImplementedException();
    }
}