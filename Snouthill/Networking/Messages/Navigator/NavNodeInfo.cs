namespace Snouthill.Networking.Messages.Navigator;

[Opcode(220)] // [[#navigator_handler, #handle_navnodeinfo]]
public record NavNodeInfo(
    bool HideFull,
    int CategoryId,
    bool PublicSpaces,
    string CategoryName,
    int CategoryCurrentVisitors,
    int CategoryMaxVisitors,
    int ParentCategoryId,
    List<(int Id, bool IsPublic, string Name, int CurrentVisitors, int MaxVisitors, int CategoryId, string Description,
        int Door, string FileNames)> Rooms,
    List<(int Id, string Name, int CurrentVisitors, int MaxVisitors, int ParentCategoryId)> SubCategories) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        message.WriteBool(HideFull);
        message.WriteInt(CategoryId);
        message.WriteInt(PublicSpaces ? 0 : 2);
        message.WriteString(CategoryName);
        message.WriteInt(CategoryCurrentVisitors);
        message.WriteInt(CategoryMaxVisitors);
        message.WriteInt(ParentCategoryId);

        if (!PublicSpaces) message.WriteInt(Rooms.Count);

        foreach (var room in Rooms)
            if (room.IsPublic)
            {
                message.WriteInt(room.Id + 1000);
                message.WriteInt(1);
                message.WriteString(room.Name);
                message.WriteInt(room.CurrentVisitors);
                message.WriteInt(room.MaxVisitors);
                message.WriteInt(room.CategoryId);
                message.WriteString(room.Description);
                message.WriteInt(room.Id);
                message.WriteInt(room.Door);
                message.WriteString(room.FileNames);
                message.WriteInt(0);
                message.WriteInt(1);
            }
            else
            {
                message.WriteInt(room.Id);
                message.WriteString(room.Name);
                message.WriteString("Owner Name$$");
                message.WriteString("0");
                message.WriteInt(room.CurrentVisitors);
                message.WriteInt(room.MaxVisitors);
                message.WriteString(room.Description);
            }

        foreach (var subcategory in SubCategories)
        {
            message.WriteInt(subcategory.Id);
            message.WriteInt(0);
            message.WriteString(subcategory.Name);
            message.WriteInt(subcategory.CurrentVisitors);
            message.WriteInt(subcategory.MaxVisitors);
            message.WriteInt(subcategory.ParentCategoryId);
        }
    }
}