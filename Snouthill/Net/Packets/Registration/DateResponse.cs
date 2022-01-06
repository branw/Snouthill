namespace Snouthill.Net.Packets.Registration;

public record DateResponse(
    string ShortDate) : IResponse
{
    public short Opcode => 163;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteString(ShortDate);
    }
}