using Snouthill.Game;

namespace Snouthill.Net.Packets.Rooms;

public record ActiveObjects(
    List<Item> Items) : IResponse
{
    public short Opcode => 32;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteInt(Items.Count);
        foreach (var item in Items) item.Serialize(writer);
    }
}