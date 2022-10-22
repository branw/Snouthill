namespace Snouthill.Networking.Messages.Account;

[Opcode(141)] // hh_entry/Login Handler/handleCheckSum
public record CheckSum(
    string Value) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        message.WriteRawString(Value);
    }
}