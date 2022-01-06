namespace Snouthill.Net.Packets.Rooms;

public record GetHeightMapResponse(
    string HeightMap) : IResponse
{
    public short Opcode => 31;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteRawString(HeightMap);
    }
}