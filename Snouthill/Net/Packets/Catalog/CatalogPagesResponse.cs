using Snouthill.Game;

namespace Snouthill.Net.Packets.Catalog;

public record CatalogPagesResponse(
    List<(string NameIndex, string Name)> Pages) : IResponse
{
    public CatalogPagesResponse(IEnumerable<CatalogPage> pages) : this(
        pages.Select(p => (p.NameIndex, p.Name)).ToList())
    {
    }

    public short Opcode => 126;

    public void Serialize(PacketWriter writer)
    {
        foreach (var page in Pages)
        {
            writer.WriteRawString(page.NameIndex);
            writer.WriteByte(9);
            writer.WriteRawString(page.Name);
            writer.WriteByte(13);
        }
    }
}