namespace Snouthill.Net.Packets.Catalog;

public record AliasToggleResponse : IResponse
{
    public short Opcode => 297;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteBool(false);
    }
}