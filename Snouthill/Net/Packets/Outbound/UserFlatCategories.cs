using Snouthill.Db.Models;

namespace Snouthill.Net.Packets.Outbound;

public record UserFlatCategories(
    List<(int Id, string Name)> Categories) : IResponse
{
    public UserFlatCategories(IEnumerable<RoomCategoryModel> categoryModels) : this(
        categoryModels.Select(cm => (cm.Id, cm.Name)).ToList())
    {
    }

    public short Opcode => 221;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteInt(Categories.Count);
        foreach (var (id, name) in Categories)
        {
            writer.WriteInt(id);
            writer.WriteString(name);
        }
    }
}