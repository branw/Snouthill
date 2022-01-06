namespace Snouthill.Net.Packets.Outbound;

public record RoomReady(
    int RoomId,
    string ModelName) : IResponse
{
    public short Opcode => 69;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteString(ModelName);
        writer.WriteString(" ");
        writer.WriteInt(RoomId);
    }
}