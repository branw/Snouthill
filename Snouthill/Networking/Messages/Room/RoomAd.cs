namespace Snouthill.Networking.Messages.Room;

[Opcode(208)] // [[#room_handler, #handle_roomad]]
public record RoomAd : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        message.WriteInt(0);
    }
}