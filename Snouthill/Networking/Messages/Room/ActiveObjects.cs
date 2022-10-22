using Snouthill.Game;

namespace Snouthill.Networking.Messages.Room;

[Opcode(32)] // [[#room_handler, #handle_activeobjects]]
public record ActiveObjects(
    List<Item> Items) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        message.WriteInt(Items.Count);
        foreach (var item in Items) item.Serialize(message);
    }
}