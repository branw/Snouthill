namespace Snouthill.Networking.Messages.Room;

[Opcode(166)] // [[#statsBrokerJs, #handle_update_stats]]
public record RoomUrl : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        message.WriteString("/client/");
    }
}