namespace Snouthill.Networking.Messages.Inbound;

[Opcode(211)] // v10~13+ "ROOM_QUEUE_CHANGE"
public record RoomQueueChange : IInboundMessage<RoomQueueChange>
{
    public static RoomQueueChange Deserialize(PacketReader reader)
    {
        throw new NotImplementedException();
    }
}