namespace Snouthill.Networking.Messages.Room;

[Opcode(153)] // "SETFLATCAT"
public record SetRoomCategory(
    int RoomId,
    int CategoryId) : IInboundMessage<SetRoomCategory>
{
    public static SetRoomCategory Deserialize(PacketReader reader)
    {
        var roomId = reader.ReadInt();
        var categoryId = reader.ReadInt();

        return new SetRoomCategory(roomId, categoryId);
    }
}