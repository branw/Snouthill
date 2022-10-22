using System.ComponentModel.DataAnnotations;

namespace Snouthill.Database.Models;

public class CatalogPackageModel
{
    [Key] public int Id { get; set; }

    public string SaleCode { get; set; } = null!;

    public int DefinitionId { get; set; }

    public int SpecialSpriteId { get; set; } = 0;

    public int Amount { get; set; } = 1;
}