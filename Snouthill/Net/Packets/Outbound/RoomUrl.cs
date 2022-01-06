namespace Snouthill.Net.Packets.Outbound;

public record RoomUrl : IResponse
{
    public short Opcode => 166;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteString("/client/");
    }
}