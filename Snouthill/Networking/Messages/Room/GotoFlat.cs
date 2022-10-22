namespace Snouthill.Networking.Messages.Room;

[Opcode(59)] // [[#roomkiosk_handler, #handle_flatcreated]]
public record RoomCreated(
    int RoomId,
    string RoomName) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        message.WriteRawString(RoomId.ToString());
        message.WriteByte(13);
        message.WriteRawString(RoomName);
    }
}