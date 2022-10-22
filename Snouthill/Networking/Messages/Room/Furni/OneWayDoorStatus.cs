namespace Snouthill.Networking.Messages.Outbound;

[Opcode(312)] // hh_room_utils/OneWayDoor Manager/changeStatus
public record OneWayDoorStatus(
    int FurniId,
    int DoorStatus) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        throw new NotImplementedException();
    }
}