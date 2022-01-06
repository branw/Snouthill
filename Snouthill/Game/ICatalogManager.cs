namespace Snouthill.Game;

public interface ICatalogManager : IManager
{
    public IEnumerable<CatalogPage> Pages { get; }
    public IEnumerable<CatalogItem> Items { get; }
    public IEnumerable<CatalogPackage> Packages { get; }
}