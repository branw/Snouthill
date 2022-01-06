namespace Snouthill.Net.Packets.Outbound;

public record GotoFlat(
    int RoomId,
    string RoomName) : IResponse
{
    public short Opcode => 59;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteRawString(RoomId.ToString());
        writer.WriteByte(13);
        writer.WriteRawString(RoomName);
    }
}