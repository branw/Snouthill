using Snouthill.Game;

namespace Snouthill.Networking.Messages.Room;

[Opcode(30)] // [[#room_handler, #handle_OBJECTS]]
public record ObjectsWorld(
    List<Item> Items) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        message.WriteInt(Items.Count);
        foreach (var item in Items) item.Serialize(message);
    }
}