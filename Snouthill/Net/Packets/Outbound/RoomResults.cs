using Snouthill.Db.Models;

namespace Snouthill.Net.Packets.Outbound;

public record RoomResults(
    List<(int Id, string Name, string OwnerName, string AccessType, int CurrentVisitors, int MaxVisitors, string
        Description)> Rooms) : IResponse
{
    public RoomResults(IEnumerable<RoomModel> roomModels) : this(
        roomModels.Select(rm => (rm.Id, rm.Name, rm.OwnerName, "", rm.CurrentVisitors, rm.MaxVisitors, rm.Description))
            .ToList())
    {
    }

    public short Opcode => 16;

    public void Serialize(PacketWriter writer)
    {
        foreach (var room in Rooms)
        {
            writer.WriteRawString(room.Id.ToString());
            writer.WriteByte(9);
            writer.WriteRawString(room.Name);
            writer.WriteByte(9);
            writer.WriteRawString(room.OwnerName);
            writer.WriteByte(9);
            writer.WriteRawString(room.AccessType);
            writer.WriteByte(9);
            writer.WriteRawString("x");
            writer.WriteByte(9);
            writer.WriteRawString(room.CurrentVisitors.ToString());
            writer.WriteByte(9);
            writer.WriteRawString(room.MaxVisitors.ToString());
            writer.WriteByte(9);
            writer.WriteRawString(room.Description);
            writer.WriteByte(9);
            writer.WriteByte(13);
        }
    }
}