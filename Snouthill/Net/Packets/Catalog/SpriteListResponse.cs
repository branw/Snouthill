namespace Snouthill.Net.Packets.Catalog;

public record SpriteListResponse : IResponse
{
    public short Opcode => 295;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteInt(0);
    }
}