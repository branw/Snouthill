namespace Snouthill.Networking.Messages.Room;

[Opcode(69)] // [[#room_handler, #handle_room_ready]]
public record RoomReady(
    int RoomId,
    string ModelName) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        message.WriteString(ModelName);
        message.WriteString(" ");
        message.WriteInt(RoomId);
    }
}