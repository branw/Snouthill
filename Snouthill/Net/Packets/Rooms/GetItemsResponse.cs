using Snouthill.Game;

namespace Snouthill.Net.Packets.Rooms;

public record GetItemsResponse(
    IEnumerable<Item> Items) : IResponse
{
    public short Opcode => 45;

    public void Serialize(PacketWriter writer)
    {
        foreach (var item in Items) item.Serialize(writer);
    }
}