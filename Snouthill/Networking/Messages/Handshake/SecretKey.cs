namespace Snouthill.Networking.Messages.Handshake;

[Opcode(1)] // hh_entry/Login Handler/handleSecretKey
public record SecretKey() : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        throw new NotImplementedException();
    }
}