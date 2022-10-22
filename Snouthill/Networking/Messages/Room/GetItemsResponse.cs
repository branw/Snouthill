using Snouthill.Game;

namespace Snouthill.Networking.Messages.Room;

[Opcode(45)] // [[#room_handler, #handle_items]]
public record GetItemsResponse(
    IEnumerable<Item> Items) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        foreach (var item in Items) item.Serialize(message);
    }
}