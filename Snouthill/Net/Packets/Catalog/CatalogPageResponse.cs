using Snouthill.Game;

namespace Snouthill.Net.Packets.Catalog;

public record CatalogPageResponse(
    CatalogPage Page,
    List<CatalogItem> Items) : IResponse
{
    public short Opcode => 127;

    public void Serialize(PacketWriter writer)
    {
        writer.WritePair("i", Page.NameIndex);
        writer.WritePair("n", Page.Name);
        writer.WritePair("l", Page.Layout);
        writer.WritePair("g", Page.ImageHeadline);

        if (!string.IsNullOrEmpty(Page.ImageTeasers)) writer.WritePair("e", Page.ImageTeasers);

        if (!string.IsNullOrEmpty(Page.Body)) writer.WritePair("h", Page.Body);

        if (!string.IsNullOrEmpty(Page.LinkList)) writer.WritePair("u", Page.LinkList);

        if (!string.IsNullOrEmpty(Page.LabelPick)) writer.WritePair("u", Page.LinkList);

        if (!string.IsNullOrEmpty(Page.LabelExtraS)) writer.WritePair("u", Page.LabelExtraS);

        for (var i = 1; i <= 10; i++)
        {
            var extra = $"label_extra_t_{i}";
        }

        foreach (var item in Items)
        {
            writer.WriteRawString("p:");
            writer.WriteRawString(item.Name);
            writer.WriteByte(9);
            writer.WriteRawString(item.Description);
            writer.WriteByte(9);
            writer.WriteRawString($"{item.Price}");
            writer.WriteByte(9);
            writer.WriteRawString("");
            writer.WriteByte(9);
            writer.WriteRawString(item.IsPackage ? "d" : "s" /*TODO wall item*/); // Type
            writer.WriteByte(9);
            writer.WriteRawString(item.IsPackage ? "" : ""); // Icon
            writer.WriteByte(9);
            writer.WriteRawString(item.IsPackage ? "" : "0"); // Size
            writer.WriteByte(9);
            writer.WriteRawString(item.IsPackage ? "" : "1,1"); // Dimensions
            writer.WriteByte(9);
            writer.WriteRawString(item.SaleCode);
            writer.WriteByte(9);

            if (item.IsPackage)
            {
                writer.WriteRawString("");
                writer.WriteByte(9);
            }

            writer.WriteByte(13);
        }
    }
}