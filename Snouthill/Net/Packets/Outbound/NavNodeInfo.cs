namespace Snouthill.Net.Packets.Outbound;

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
    List<(int Id, string Name, int CurrentVisitors, int MaxVisitors, int ParentCategoryId)> SubCategories) : IResponse
{
    public short Opcode => 220;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteBool(HideFull);
        writer.WriteInt(CategoryId);
        writer.WriteInt(PublicSpaces ? 0 : 2);
        writer.WriteString(CategoryName);
        writer.WriteInt(CategoryCurrentVisitors);
        writer.WriteInt(CategoryMaxVisitors);
        writer.WriteInt(ParentCategoryId);

        if (!PublicSpaces) writer.WriteInt(Rooms.Count);

        foreach (var room in Rooms)
            if (room.IsPublic)
            {
                writer.WriteInt(room.Id + 1000);
                writer.WriteInt(1);
                writer.WriteString(room.Name);
                writer.WriteInt(room.CurrentVisitors);
                writer.WriteInt(room.MaxVisitors);
                writer.WriteInt(room.CategoryId);
                writer.WriteString(room.Description);
                writer.WriteInt(room.Id);
                writer.WriteInt(room.Door);
                writer.WriteString(room.FileNames);
                writer.WriteInt(0);
                writer.WriteInt(1);
            }
            else
            {
                writer.WriteInt(room.Id);
                writer.WriteString(room.Name);
                writer.WriteString("Owner Name$$");
                writer.WriteString("0");
                writer.WriteInt(room.CurrentVisitors);
                writer.WriteInt(room.MaxVisitors);
                writer.WriteString(room.Description);
            }

        foreach (var subcategory in SubCategories)
        {
            writer.WriteInt(subcategory.Id);
            writer.WriteInt(0);
            writer.WriteString(subcategory.Name);
            writer.WriteInt(subcategory.CurrentVisitors);
            writer.WriteInt(subcategory.MaxVisitors);
            writer.WriteInt(subcategory.ParentCategoryId);
        }
    }
}