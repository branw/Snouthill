namespace Snouthill.Networking.Messages.Room.Furni;

[Opcode(232)] // "ENTER_ONEWAY_DOOR" hh_room_utils/OneWayDoor Manager
public record EnterOneWayDoor(
    int PlayerId) : IInboundMessage<EnterOneWayDoor>
{
    public static EnterOneWayDoor Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}