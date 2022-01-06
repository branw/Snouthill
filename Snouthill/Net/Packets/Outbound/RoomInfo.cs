using Snouthill.Db.Models;

namespace Snouthill.Net.Packets.Outbound;

public record RoomInfo(
    bool AllowSuperUsers,
    int AccessTypeId,
    int Id,
    string OwnerName,
    string LayoutName,
    string Name,
    string Description,
    bool ShowOwnerName,
    bool AllowTrading,
    bool NoCategory,
    int CurrentVisitors,
    int MaxVisitors) : IResponse
{
    public RoomInfo(RoomModel roomModel) : this(true, 0, roomModel.Id, roomModel.OwnerName,
        roomModel.LayoutName, roomModel.Name, roomModel.Description, roomModel.ShowOwnerName,
        true, false, roomModel.CurrentVisitors, roomModel.MaxVisitors)
    {
    }

    public short Opcode => 54;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteBool(AllowSuperUsers);
        writer.WriteInt(AccessTypeId);
        writer.WriteInt(Id);
        writer.WriteString(OwnerName);
        writer.WriteString(LayoutName);
        writer.WriteString(Name);
        writer.WriteString(Description);
        writer.WriteBool(ShowOwnerName);
        writer.WriteBool(AllowTrading);
        writer.WriteBool(NoCategory);
        writer.WriteInt(CurrentVisitors);
        writer.WriteInt(MaxVisitors);
    }
}