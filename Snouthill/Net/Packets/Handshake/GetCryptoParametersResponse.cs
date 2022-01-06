namespace Snouthill.Net.Packets.Handshake;

public record GetCryptoParametersResponse : IResponse
{
    public short Opcode => 277;

    public void Serialize(PacketWriter writer)
    {
        // Disable RC4 encryption
        writer.WriteInt(0);
    }
}