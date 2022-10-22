using Snouthill.Database.Models;

namespace Snouthill.Networking.Messages.Room;

public record RoomInfo(
    int Id,
    string Name,
    string OwnerName,
    string AccessType,
    int CurrentVisitors,
    int MaxVisitors,
    string Description);

[Opcode(16)] // [[#navigator_handler, #handle_flat_results]]
public record RoomResults(
    List<RoomInfo> Rooms) : IOutboundMessage
{
    public RoomResults(IEnumerable<RoomModel> roomModels) : this(
        roomModels.Select(rm => new RoomInfo(rm.Id, rm.Name, rm.OwnerName ?? "", "", rm.CurrentVisitors, rm.MaxVisitors, rm.Description))
            .ToList())
    {
    }

    public void Serialize(PacketWriter message)
    {
        foreach (var room in Rooms)
        {
            message.WriteRawString(room.Id.ToString());
            message.WriteByte(9);
            message.WriteRawString(room.Name);
            message.WriteByte(9);
            message.WriteRawString(room.OwnerName);
            message.WriteByte(9);
            message.WriteRawString(room.AccessType);
            message.WriteByte(9);
            message.WriteRawString("x");
            message.WriteByte(9);
            message.WriteRawString(room.CurrentVisitors.ToString());
            message.WriteByte(9);
            message.WriteRawString(room.MaxVisitors.ToString());
            message.WriteByte(9);
            message.WriteRawString(room.Description);
            message.WriteByte(9);
            message.WriteByte(13);
        }
    }
}