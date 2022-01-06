namespace Snouthill.Net.Packets.Rooms;

public record GetInterstitialResponse(
    string ImageUrl,
    string LinkUrl) : IResponse
{
    public short Opcode => 258;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteInt(0);
    }
}