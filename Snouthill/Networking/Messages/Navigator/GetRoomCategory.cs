namespace Snouthill.Networking.Messages.Room;

[Opcode(152)] // "GETFLATCAT"
public record GetRoomCategory(
    int RoomId) : IInboundMessage<GetRoomCategory>
{
    public static GetRoomCategory Deserialize(PacketReader reader)
    {
        var roomId = reader.ReadInt();

        return new GetRoomCategory(roomId);
    }
}