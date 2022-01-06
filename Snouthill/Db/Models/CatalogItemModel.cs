using System.ComponentModel.DataAnnotations;

namespace Snouthill.Db.Models;

public class CatalogItemModel
{
    [Key] public int Id { get; set; }

    public string SaleCode { get; set; }

    public IEnumerable<int> PageIds { get; set; }

    public int SortIndex { get; set; } = 0;

    public int Price { get; set; } = 3;

    public bool IsHidden { get; set; } = false;

    public int Amount { get; set; } = 1;

    public int DefinitionId { get; set; }

    public int SpecialSpriteId { get; set; } = 0;

    public string Name { get; set; }

    public string Description { get; set; }

    public bool IsPackage { get; set; } = false;

    public string? PackageName { get; set; } = null;

    public string? PackageDescription { get; set; } = null;
}