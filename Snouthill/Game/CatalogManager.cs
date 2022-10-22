using Snouthill.Database;

namespace Snouthill.Game;

public class CatalogManager
{
    private List<CatalogItem> _items = new();
    private List<CatalogPackage> _packages = new();
    private List<CatalogPage> _pages = new();
    public IEnumerable<CatalogPage> Pages => _pages;

    public IEnumerable<CatalogItem> Items => _items;

    public IEnumerable<CatalogPackage> Packages => _packages;

    public void Load()
    {
        using var db = new DatabaseContext();
        _pages = db.CatalogPages.AsEnumerable()
            .Select(cp => new CatalogPage(cp.Id, cp.NameIndex, cp.LinkList, cp.Name,
                cp.Layout, cp.ImageHeadline, cp.ImageTeasers, cp.Body, cp.LabelPick, cp.LabelExtraS,
                cp.LabelExtraT))
            .ToList();

        _packages = db.CatalogPackages.AsEnumerable()
            .Select(cp => new CatalogPackage(cp.SaleCode, cp.DefinitionId, cp.SpecialSpriteId, cp.Amount))
            .ToList();

        _items = db.CatalogItems.AsEnumerable()
            .Select(ci => new CatalogItem(ci.Id, ci.SaleCode, ci.Name, ci.Description, ci.SortIndex, ci.IsHidden,
                ci.Price, ci.SpecialSpriteId, ci.PageIds, ci.IsPackage, ci.PackageName, ci.PackageDescription))
            .ToList();
    }
}