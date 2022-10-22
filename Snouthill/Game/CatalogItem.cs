namespace Snouthill.Game;

public record CatalogItem(
    int Id,
    string SaleCode,
    string Name,
    string Description,
    int SortIndex,
    bool IsHidden,
    int Price,
    int SpecialItemId,
    IEnumerable<int> PageIds,
    bool IsPackage,
    string? PackageName,
    string? PackageDescription);