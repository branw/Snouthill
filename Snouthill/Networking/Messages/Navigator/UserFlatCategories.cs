using Snouthill.Database.Models;

namespace Snouthill.Networking.Messages.Outbound;

[Opcode(221)] // [[#navigator_handler, #handle_userflatcats]]
public record UserFlatCategories(
    List<(int Id, string Name)> Categories) : IOutboundMessage
{
    public UserFlatCategories(IEnumerable<RoomCategoryModel> categoryModels) : this(
        categoryModels.Select(cm => (cm.Id, cm.Name)).ToList())
    {
    }

    public void Serialize(PacketWriter message)
    {
        message.WriteInt(Categories.Count);
        foreach (var (id, name) in Categories)
        {
            message.WriteInt(id);
            message.WriteString(name);
        }
    }
}