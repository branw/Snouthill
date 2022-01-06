using Snouthill.Game;

namespace Snouthill.Net.Packets.Rooms;

public record ObjectsWorld(
    List<Item> Items) : IResponse
{
    public short Opcode => 30;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteInt(Items.Count);
        foreach (var item in Items) item.Serialize(writer);
    }
}