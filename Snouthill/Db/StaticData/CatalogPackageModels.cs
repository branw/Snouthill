using Snouthill.Db.Models;

namespace Snouthill.Db.StaticData;

public class CatalogPackageModels
{
    public static readonly IEnumerable<CatalogPackageModel> Models = new List<CatalogPackageModel>
    {
        new() {Id = 1, SaleCode = "a0 deal102", DefinitionId = 184, SpecialSpriteId = 0, Amount = 5},
        new() {Id = 2, SaleCode = "a0 deal104", DefinitionId = 184, SpecialSpriteId = 0, Amount = 3},
        new() {Id = 3, SaleCode = "a0 deal105", DefinitionId = 180, SpecialSpriteId = 0, Amount = 5},
        new() {Id = 4, SaleCode = "a0 deal106", DefinitionId = 180, SpecialSpriteId = 0, Amount = 3},
        new() {Id = 5, SaleCode = "a0 deal107", DefinitionId = 181, SpecialSpriteId = 0, Amount = 5},
        new() {Id = 6, SaleCode = "a0 deal108", DefinitionId = 181, SpecialSpriteId = 0, Amount = 3},
        new() {Id = 7, SaleCode = "a0 deal109", DefinitionId = 182, SpecialSpriteId = 0, Amount = 5},
        new() {Id = 8, SaleCode = "a0 deal114", DefinitionId = 182, SpecialSpriteId = 0, Amount = 3},
        new() {Id = 9, SaleCode = "a0 deal115", DefinitionId = 183, SpecialSpriteId = 0, Amount = 5},
        new() {Id = 10, SaleCode = "a0 deal116", DefinitionId = 183, SpecialSpriteId = 0, Amount = 3},
        new() {Id = 11, SaleCode = "deal_dogfood", DefinitionId = 155, SpecialSpriteId = 0, Amount = 6},
        new() {Id = 12, SaleCode = "deal_catfood", DefinitionId = 156, SpecialSpriteId = 0, Amount = 6},
        new() {Id = 13, SaleCode = "deal_crocfood", DefinitionId = 236, SpecialSpriteId = 0, Amount = 6},
        new() {Id = 14, SaleCode = "deal_cabbage", DefinitionId = 157, SpecialSpriteId = 0, Amount = 6},
        new() {Id = 15, SaleCode = "sound_machine_deal", DefinitionId = 232, SpecialSpriteId = 0, Amount = 1},
        new() {Id = 16, SaleCode = "sound_machine_deal", DefinitionId = 239, SpecialSpriteId = 0, Amount = 1},
        new() {Id = 17, SaleCode = "deal_hcrollers", DefinitionId = 226, SpecialSpriteId = 0, Amount = 5},
        new() {Id = 18, SaleCode = "deal_throne", DefinitionId = 107, SpecialSpriteId = 0, Amount = 10}
    };
}