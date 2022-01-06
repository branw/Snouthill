namespace Snouthill.Net.Packets.Rooms;

public record GetRoomAdResponse : IResponse
{
    public short Opcode => 208;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteInt(0);
    }
}