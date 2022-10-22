namespace Snouthill.Networking.Messages.Handshake;

[Opcode(277)] // hh_entry/Login Handler/handleCryptoParameters
public record CryptoParameters(
    bool EnableResponseEncryption = false) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        message.WriteBool(EnableResponseEncryption);
    }
}