using Snouthill.Database.Models;

namespace Snouthill.Database.StaticData;

public static class CatalogItemModels
{
    public static readonly IEnumerable<CatalogItemModel> Models = new List<CatalogItemModel>
    {
        new()
        {
            Id = 1, SaleCode = "floor", PageIds = new List<int> {3}, SortIndex = 1, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 249, SpecialSpriteId = 0, Name = "", Description = ""
        },
        new()
        {
            Id = 2, SaleCode = "CF_50_goldbar", PageIds = new List<int> {4}, SortIndex = 5, Price = 50,
            IsHidden = false, Amount = 1, DefinitionId = 212, SpecialSpriteId = 0, Name = "Gold Bar",
            Description = "Worth 50 Credits"
        },
        new()
        {
            Id = 3, SaleCode = "CF_20_moneybag", PageIds = new List<int> {4}, SortIndex = 4, Price = 20,
            IsHidden = false, Amount = 1, DefinitionId = 211, SpecialSpriteId = 0, Name = "Sack of Credits",
            Description = "Worth 20 Credits"
        },
        new()
        {
            Id = 4, SaleCode = "CF_10_coin_gold", PageIds = new List<int> {4}, SortIndex = 3, Price = 10,
            IsHidden = false, Amount = 1, DefinitionId = 209, SpecialSpriteId = 0, Name = "Gold Coin",
            Description = "Worth 10 Credits"
        },
        new()
        {
            Id = 5, SaleCode = "CF_5_coin_silver", PageIds = new List<int> {4}, SortIndex = 2, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 213, SpecialSpriteId = 0, Name = "Silver Coin",
            Description = "Worth 5 Credits"
        },
        new()
        {
            Id = 6, SaleCode = "CF_1_coin_bronze", PageIds = new List<int> {4}, SortIndex = 1, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 210, SpecialSpriteId = 0, Name = "Bronze Coin",
            Description = "Worth 1 Credits"
        },
        new()
        {
            Id = 7, SaleCode = "a0 deal102", PageIds = new List<int> {5}, SortIndex = 1, Price = 25, IsHidden = false,
            Amount = 1, DefinitionId = 0, SpecialSpriteId = 0, Name = "", Description = "", IsPackage = true,
            PackageName = "Red Roller 5 Pack", PackageDescription = "5 Red Rollers in a convenient pack"
        },
        new()
        {
            Id = 8, SaleCode = "a0 deal104", PageIds = new List<int> {5}, SortIndex = 2, Price = 15, IsHidden = false,
            Amount = 1, DefinitionId = 0, SpecialSpriteId = 0, Name = "", Description = "", IsPackage = true,
            PackageName = "Red Roller 3 Pack", PackageDescription = "3 Red Rollers in a convenient pack"
        },
        new()
        {
            Id = 9, SaleCode = "queue_tile1*2", PageIds = new List<int> {5}, SortIndex = 3, Price = 7, IsHidden = false,
            Amount = 1, DefinitionId = 184, SpecialSpriteId = 0, Name = "Red Habbo Roller",
            Description = "The power of movement"
        },
        new()
        {
            Id = 10, SaleCode = "a0 deal105", PageIds = new List<int> {5}, SortIndex = 4, Price = 25, IsHidden = false,
            Amount = 1, DefinitionId = 0, SpecialSpriteId = 0, Name = "", Description = "", IsPackage = true,
            PackageName = "Blue Roller 5 Pack", PackageDescription = "5 Blue Rollers in a convenient pack"
        },
        new()
        {
            Id = 11, SaleCode = "a0 deal106", PageIds = new List<int> {5}, SortIndex = 5, Price = 15, IsHidden = false,
            Amount = 1, DefinitionId = 0, SpecialSpriteId = 0, Name = "", Description = "", IsPackage = true,
            PackageName = "Blue Roller 3 Pack", PackageDescription = "3 Blue Rollers in a convenient pack"
        },
        new()
        {
            Id = 12, SaleCode = "queue_tile1*6", PageIds = new List<int> {5}, SortIndex = 6, Price = 7,
            IsHidden = false, Amount = 1, DefinitionId = 180, SpecialSpriteId = 0, Name = "Blue Habbo Roller",
            Description = "The power of movement"
        },
        new()
        {
            Id = 13, SaleCode = "a0 deal107", PageIds = new List<int> {5}, SortIndex = 7, Price = 25, IsHidden = false,
            Amount = 1, DefinitionId = 0, SpecialSpriteId = 0, Name = "", Description = "", IsPackage = true,
            PackageName = "Green Roller 5 Pack", PackageDescription = "5 Green Rollers in a convenient pack"
        },
        new()
        {
            Id = 14, SaleCode = "a0 deal108", PageIds = new List<int> {5}, SortIndex = 8, Price = 15, IsHidden = false,
            Amount = 1, DefinitionId = 0, SpecialSpriteId = 0, Name = "", Description = "", IsPackage = true,
            PackageName = "Greek Roller 3 Pack", PackageDescription = "3 Green Rollers in a convenient pack"
        },
        new()
        {
            Id = 15, SaleCode = "queue_tile1*9", PageIds = new List<int> {5}, SortIndex = 9, Price = 7,
            IsHidden = false, Amount = 1, DefinitionId = 181, SpecialSpriteId = 0, Name = "Green Habbo Roller",
            Description = "The power of movement"
        },
        new()
        {
            Id = 16, SaleCode = "a0 deal109", PageIds = new List<int> {5}, SortIndex = 10, Price = 25, IsHidden = false,
            Amount = 1, DefinitionId = 0, SpecialSpriteId = 0, Name = "", Description = "", IsPackage = true,
            PackageName = "Navy Roller 5 Pack", PackageDescription = "5 Navy Rollers in a convenient pack"
        },
        new()
        {
            Id = 17, SaleCode = "a0 deal114", PageIds = new List<int> {5}, SortIndex = 11, Price = 15, IsHidden = false,
            Amount = 1, DefinitionId = 0, SpecialSpriteId = 0, Name = "", Description = "", IsPackage = true,
            PackageName = "Navy Roller 3 Pack", PackageDescription = "3 Navy Rollers in a convenient pack"
        },
        new()
        {
            Id = 18, SaleCode = "queue_tile1*8", PageIds = new List<int> {5}, SortIndex = 12, Price = 7,
            IsHidden = false, Amount = 1, DefinitionId = 182, SpecialSpriteId = 0, Name = "Navy Habbo Roller",
            Description = "The power of movement"
        },
        new()
        {
            Id = 19, SaleCode = "a0 deal115", PageIds = new List<int> {5}, SortIndex = 14, Price = 25, IsHidden = false,
            Amount = 1, DefinitionId = 0, SpecialSpriteId = 0, Name = "", Description = "", IsPackage = true,
            PackageName = "Purple Roller 5 Pack", PackageDescription = "5 Purple Rollers in a convenient pack"
        },
        new()
        {
            Id = 20, SaleCode = "queue_tile1*7", PageIds = new List<int> {5}, SortIndex = 16, Price = 7,
            IsHidden = false, Amount = 1, DefinitionId = 183, SpecialSpriteId = 0, Name = "Purple Habbo Roller",
            Description = "The power of movement"
        },
        new()
        {
            Id = 21, SaleCode = "a0 deal116", PageIds = new List<int> {5}, SortIndex = 15, Price = 15, IsHidden = false,
            Amount = 1, DefinitionId = 0, SpecialSpriteId = 0, Name = "", Description = "", IsPackage = true,
            PackageName = "Purple Roller 3 Pack", PackageDescription = "3 Purple Rollers in a convenient pack"
        },
        new()
        {
            Id = 22, SaleCode = "door", PageIds = new List<int> {6}, SortIndex = 1, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 100, SpecialSpriteId = 0, Name = "Telephone Box", Description = "Dr Who?"
        },
        new()
        {
            Id = 23, SaleCode = "doorC", PageIds = new List<int> {6}, SortIndex = 2, Price = 4, IsHidden = false,
            Amount = 1, DefinitionId = 102, SpecialSpriteId = 0, Name = "Portaloo", Description = "In a hurry?"
        },
        new()
        {
            Id = 24, SaleCode = "doorB", PageIds = new List<int> {6}, SortIndex = 3, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 101, SpecialSpriteId = 0, Name = "Wardrobe", Description = "Narnia this way!"
        },
        new()
        {
            Id = 25, SaleCode = "pets0", PageIds = new List<int> {7}, SortIndex = 1, Price = 20, IsHidden = false,
            Amount = 1, DefinitionId = 154, SpecialSpriteId = 0, Name = "", Description = ""
        },
        new()
        {
            Id = 26, SaleCode = "pets1", PageIds = new List<int> {7}, SortIndex = 2, Price = 20, IsHidden = false,
            Amount = 1, DefinitionId = 776, SpecialSpriteId = 0, Name = "", Description = ""
        },
        new()
        {
            Id = 27, SaleCode = "pets2", PageIds = new List<int> {7}, SortIndex = 3, Price = 20, IsHidden = false,
            Amount = 1, DefinitionId = 777, SpecialSpriteId = 0, Name = "", Description = ""
        },
        new()
        {
            Id = 28, SaleCode = "deal_dogfood", PageIds = new List<int> {8}, SortIndex = 1, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 0, SpecialSpriteId = 0, Name = "", Description = "", IsPackage = true,
            PackageName = "Doggy Bones", PackageDescription = "Natural nutrition for the barking one"
        },
        new()
        {
            Id = 29, SaleCode = "deal_catfood", PageIds = new List<int> {8}, SortIndex = 2, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 0, SpecialSpriteId = 0, Name = "", Description = "", IsPackage = true,
            PackageName = "Sardines", PackageDescription = "Fresh catch of the day"
        },
        new()
        {
            Id = 30, SaleCode = "deal_crocfood", PageIds = new List<int> {8}, SortIndex = 3, Price = 2,
            IsHidden = false, Amount = 1, DefinitionId = 0, SpecialSpriteId = 0, Name = "", Description = "",
            IsPackage = true, PackageName = "T-Bones", PackageDescription = "For the croc!"
        },
        new()
        {
            Id = 31, SaleCode = "deal_cabbage", PageIds = new List<int> {8}, SortIndex = 4, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 0, SpecialSpriteId = 0, Name = "", Description = "", IsPackage = true,
            PackageName = "Cabbage", PackageDescription = "Health food for pets"
        },
        new()
        {
            Id = 32, SaleCode = "petfood1", PageIds = new List<int> {8}, SortIndex = 5, Price = 1, IsHidden = false,
            Amount = 1, DefinitionId = 155, SpecialSpriteId = 0, Name = "Bones Mega Multipack",
            Description = "Fantastic 20% Saving!"
        },
        new()
        {
            Id = 33, SaleCode = "petfood2", PageIds = new List<int> {8}, SortIndex = 6, Price = 1, IsHidden = false,
            Amount = 1, DefinitionId = 156, SpecialSpriteId = 0, Name = "Sardines Mega Multipack",
            Description = "Fantastic 20% Saving!"
        },
        new()
        {
            Id = 34, SaleCode = "petfood4", PageIds = new List<int> {8}, SortIndex = 7, Price = 1, IsHidden = false,
            Amount = 1, DefinitionId = 236, SpecialSpriteId = 0, Name = "T-Bones Mega Multipack",
            Description = "Fantastic 20% Saving!"
        },
        new()
        {
            Id = 35, SaleCode = "petfood3", PageIds = new List<int> {8}, SortIndex = 8, Price = 1, IsHidden = false,
            Amount = 1, DefinitionId = 157, SpecialSpriteId = 0, Name = "Cabbage Mega Multipack",
            Description = "Fantastic 20% Saving!"
        },
        new()
        {
            Id = 36, SaleCode = "waterbowl*4", PageIds = new List<int> {8}, SortIndex = 9, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 158, SpecialSpriteId = 0, Name = "Blue Water Bowl",
            Description = "Aqua unlimited"
        },
        new()
        {
            Id = 37, SaleCode = "waterbowl*5", PageIds = new List<int> {8}, SortIndex = 10, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 159, SpecialSpriteId = 0, Name = "Brown Water Bowl",
            Description = "Aqua unlimited"
        },
        new()
        {
            Id = 38, SaleCode = "waterbowl*2", PageIds = new List<int> {8}, SortIndex = 11, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 160, SpecialSpriteId = 0, Name = "Green Water Bowl",
            Description = "Aqua unlimited"
        },
        new()
        {
            Id = 39, SaleCode = "waterbowl*1", PageIds = new List<int> {8}, SortIndex = 12, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 161, SpecialSpriteId = 0, Name = "Red Water Bowl", Description = "Aqua unlimited"
        },
        new()
        {
            Id = 40, SaleCode = "waterbowl*3", PageIds = new List<int> {8}, SortIndex = 13, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 162, SpecialSpriteId = 0, Name = "Yellow Water Bowl",
            Description = "Aqua unlimited"
        },
        new()
        {
            Id = 41, SaleCode = "goodie2", PageIds = new List<int> {8}, SortIndex = 14, Price = 1, IsHidden = false,
            Amount = 1, DefinitionId = 169, SpecialSpriteId = 0, Name = "Chocolate Mouse",
            Description = "For gourmet kittens"
        },
        new()
        {
            Id = 42, SaleCode = "goodie1", PageIds = new List<int> {8}, SortIndex = 15, Price = 1, IsHidden = false,
            Amount = 1, DefinitionId = 168, SpecialSpriteId = 0, Name = "Marzipan Man",
            Description = "Crunchy Dog Treat"
        },
        new()
        {
            Id = 43, SaleCode = "toy1", PageIds = new List<int> {8}, SortIndex = 16, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 163, SpecialSpriteId = 0, Name = "Rubber Ball",
            Description = "it's bouncy-tastic"
        },
        new()
        {
            Id = 44, SaleCode = "toy1*1", PageIds = new List<int> {8}, SortIndex = 17, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 164, SpecialSpriteId = 0, Name = "Rubber Ball",
            Description = "it's bouncy-tastic"
        },
        new()
        {
            Id = 45, SaleCode = "toy1*2", PageIds = new List<int> {8}, SortIndex = 18, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 165, SpecialSpriteId = 0, Name = "Rubber Ball",
            Description = "it's bouncy-tastic"
        },
        new()
        {
            Id = 46, SaleCode = "toy1*3", PageIds = new List<int> {8}, SortIndex = 19, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 166, SpecialSpriteId = 0, Name = "Rubber Ball",
            Description = "it's bouncy-tastic"
        },
        new()
        {
            Id = 47, SaleCode = "toy1*4", PageIds = new List<int> {8}, SortIndex = 20, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 167, SpecialSpriteId = 0, Name = "Rubber Ball",
            Description = "it's bouncy-tastic"
        },
        new()
        {
            Id = 48, SaleCode = "bed_silo_two", PageIds = new List<int> {9}, SortIndex = 1, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 20, SpecialSpriteId = 0, Name = "Double Bed", Description = "Plain and simple x2"
        },
        new()
        {
            Id = 49, SaleCode = "bed_silo_one", PageIds = new List<int> {9}, SortIndex = 2, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 19, SpecialSpriteId = 0, Name = "Single Bed", Description = "Plain and simple"
        },
        new()
        {
            Id = 50, SaleCode = "shelves_silo", PageIds = new List<int> {9}, SortIndex = 3, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 3, SpecialSpriteId = 0, Name = "Bookcase",
            Description = "For nic naks and art deco books"
        },
        new()
        {
            Id = 51, SaleCode = "sofa_silo", PageIds = new List<int> {9}, SortIndex = 4, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 9, SpecialSpriteId = 0, Name = "Two-Seater Sofa",
            Description = "Cushioned, understated comfort"
        },
        new()
        {
            Id = 52, SaleCode = "sofachair_silo", PageIds = new List<int> {9}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 16, SpecialSpriteId = 0, Name = "Armchair",
            Description = "Large, but worth it"
        },
        new()
        {
            Id = 53, SaleCode = "table_silo_small", PageIds = new List<int> {9}, SortIndex = 6, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 21, SpecialSpriteId = 0, Name = "Occasional Table",
            Description = "For those random moments"
        },
        new()
        {
            Id = 54, SaleCode = "divider_silo3", PageIds = new List<int> {9}, SortIndex = 7, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 122, SpecialSpriteId = 0, Name = "Gate (lockable)",
            Description = "Form following function"
        },
        new()
        {
            Id = 55, SaleCode = "divider_silo2", PageIds = new List<int> {9}, SortIndex = 8, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 120, SpecialSpriteId = 0, Name = "Screen",
            Description = "Stylish sectioning"
        },
        new()
        {
            Id = 56, SaleCode = "divider_silo1", PageIds = new List<int> {9}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 118, SpecialSpriteId = 0, Name = "Corner Shelf",
            Description = "Neat and natty"
        },
        new()
        {
            Id = 57, SaleCode = "chair_silo", PageIds = new List<int> {9}, SortIndex = 10, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 8, SpecialSpriteId = 0, Name = "Dining Chair", Description = "Keep it simple"
        },
        new()
        {
            Id = 58, SaleCode = "safe_silo", PageIds = new List<int> {9}, SortIndex = 11, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 203, SpecialSpriteId = 0, Name = "Safe Minibar",
            Description = "Totally shatter-proof!"
        },
        new()
        {
            Id = 59, SaleCode = "barchair_silo", PageIds = new List<int> {9}, SortIndex = 12, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 197, SpecialSpriteId = 0, Name = "Bar Stool",
            Description = "Practical and convenient"
        },
        new()
        {
            Id = 60, SaleCode = "table_silo_med", PageIds = new List<int> {9}, SortIndex = 13, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 6, SpecialSpriteId = 0, Name = "Coffee Table",
            Description = "Wipe clean and unobtrusive"
        },
        new()
        {
            Id = 61, SaleCode = "gothic_chair*3", PageIds = new List<int> {10}, SortIndex = 1, Price = 10,
            IsHidden = false, Amount = 1, DefinitionId = 229, SpecialSpriteId = 0, Name = "Red Gothic Chair",
            Description = "The head of the table"
        },
        new()
        {
            Id = 62, SaleCode = "gothic_sofa*3", PageIds = new List<int> {10}, SortIndex = 2, Price = 7,
            IsHidden = false, Amount = 1, DefinitionId = 230, SpecialSpriteId = 0, Name = "Red Gothic Sofa",
            Description = "Not great for hiding behind"
        },
        new()
        {
            Id = 63, SaleCode = "gothic_stool*3", PageIds = new List<int> {10}, SortIndex = 3, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 231, SpecialSpriteId = 0, Name = "Red Gothic Stool",
            Description = "Be calm. Be seated"
        },
        new()
        {
            Id = 64, SaleCode = "gothic_carpet", PageIds = new List<int> {10}, SortIndex = 4, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 237, SpecialSpriteId = 0, Name = "Cobbled Path",
            Description = "The path less travelled"
        },
        new()
        {
            Id = 65, SaleCode = "gothic_carpet2", PageIds = new List<int> {10}, SortIndex = 5, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 238, SpecialSpriteId = 0, Name = "Dungeon Floor",
            Description = "What lies beneath?"
        },
        new()
        {
            Id = 66, SaleCode = "goth_table", PageIds = new List<int> {10}, SortIndex = 6, Price = 15, IsHidden = false,
            Amount = 1, DefinitionId = 218, SpecialSpriteId = 0, Name = "Gothic table",
            Description = "The dark side of Habbo"
        },
        new()
        {
            Id = 67, SaleCode = "gothrailing", PageIds = new List<int> {10}, SortIndex = 7, Price = 8, IsHidden = false,
            Amount = 1, DefinitionId = 217, SpecialSpriteId = 0, Name = "Gothic Railing",
            Description = "The dark side of Habbo"
        },
        new()
        {
            Id = 68, SaleCode = "gothgate", PageIds = new List<int> {10}, SortIndex = 8, Price = 10, IsHidden = false,
            Amount = 1, DefinitionId = 215, SpecialSpriteId = 0, Name = "Gothic Portcullis",
            Description = "The dark side of Habbo"
        },
        new()
        {
            Id = 69, SaleCode = "torch", PageIds = new List<int> {10}, SortIndex = 9, Price = 7, IsHidden = false,
            Amount = 1, DefinitionId = 248, SpecialSpriteId = 0, Name = "Gothic Torch",
            Description = "The dark side of Habbo"
        },
        new()
        {
            Id = 70, SaleCode = "gothicfountain", PageIds = new List<int> {10}, SortIndex = 10, Price = 7,
            IsHidden = false, Amount = 1, DefinitionId = 245, SpecialSpriteId = 0, Name = "Gothic Ectoplasm Fountain",
            Description = "Not suitable for drinking!"
        },
        new()
        {
            Id = 71, SaleCode = "gothiccandelabra", PageIds = new List<int> {10}, SortIndex = 11, Price = 8,
            IsHidden = false, Amount = 1, DefinitionId = 216, SpecialSpriteId = 0, Name = "Gothic Candelabra",
            Description = "The dark side of Habbo"
        },
        new()
        {
            Id = 72, SaleCode = "industrialfan", PageIds = new List<int> {10}, SortIndex = 12, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 247, SpecialSpriteId = 0, Name = "Industrial Turbine",
            Description = "Powerful and resilient"
        },
        new()
        {
            Id = 73, SaleCode = "sound_machine_deal", PageIds = new List<int> {85, 86, 87, 88, 89}, SortIndex = 1,
            Price = 10, IsHidden = false, Amount = 1, DefinitionId = 0, SpecialSpriteId = 0, Name = "",
            Description = "", IsPackage = true, PackageName = "Soundmachine starterset",
            PackageDescription = "Gray soundmachine with Duck Funk sampleset"
        },
        new()
        {
            Id = 74, SaleCode = "sound_set_1", PageIds = new List<int> {88}, SortIndex = 9, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 239, SpecialSpriteId = 0, Name = "Habbo Sounds 1",
            Description = "Get the party started!"
        },
        new()
        {
            Id = 75, SaleCode = "sound_set_2", PageIds = new List<int> {88}, SortIndex = 9, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 358, SpecialSpriteId = 0, Name = "Habbo Sounds 3",
            Description = "Get the party started!"
        },
        new()
        {
            Id = 76, SaleCode = "sound_set_4", PageIds = new List<int> {85}, SortIndex = 9, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 359, SpecialSpriteId = 0, Name = "Ambient 1", Description = "Chilled out beats"
        },
        new()
        {
            Id = 77, SaleCode = "sound_set_5", PageIds = new List<int> {85}, SortIndex = 9, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 360, SpecialSpriteId = 0, Name = "Ambient 4",
            Description = "The dark side of Habbo"
        },
        new()
        {
            Id = 78, SaleCode = "sound_set_3", PageIds = new List<int> {85}, SortIndex = 4, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 240, SpecialSpriteId = 0, Name = "Electronic 1", Description = "Chilled grooves"
        },
        new()
        {
            Id = 79, SaleCode = "sound_set_6", PageIds = new List<int> {85}, SortIndex = 9, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 241, SpecialSpriteId = 0, Name = "Ambient 3",
            Description = "Background ambience loops"
        },
        new()
        {
            Id = 80, SaleCode = "sound_set_7", PageIds = new List<int> {88}, SortIndex = 9, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 242, SpecialSpriteId = 0, Name = "SFX 5", Description = "Sound effects for Furni"
        },
        new()
        {
            Id = 81, SaleCode = "sound_set_9", PageIds = new List<int> {85}, SortIndex = 9, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 356, SpecialSpriteId = 0, Name = "Electronic 2",
            Description = "Mystical ambient soundscapes"
        },
        new()
        {
            Id = 82, SaleCode = "sound_set_8", PageIds = new List<int> {85}, SortIndex = 9, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 243, SpecialSpriteId = 0, Name = "Ambient 2",
            Description = "Mellow electric grooves"
        },
        new()
        {
            Id = 83, SaleCode = "bardesk_polyfon*5", PageIds = new List<int> {12}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 198, SpecialSpriteId = 0, Name = "Candy Bar",
            Description = "For cute constructions"
        },
        new()
        {
            Id = 84, SaleCode = "bardeskcorner_polyfon*5", PageIds = new List<int> {12}, SortIndex = 2, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 199, SpecialSpriteId = 0, Name = "Candy Corner",
            Description = "For sweet corners!"
        },
        new()
        {
            Id = 85, SaleCode = "divider_poly3*5", PageIds = new List<int> {12}, SortIndex = 3, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 200, SpecialSpriteId = 0, Name = "Candy Hatch (Lockable)",
            Description = "Keep the Pink in!"
        },
        new()
        {
            Id = 86, SaleCode = "sofachair_polyfon_girl", PageIds = new List<int> {12}, SortIndex = 4, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 64, SpecialSpriteId = 0, Name = "Armchair",
            Description = "Think pink"
        },
        new()
        {
            Id = 87, SaleCode = "sofa_polyfon_girl", PageIds = new List<int> {12}, SortIndex = 5, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 67, SpecialSpriteId = 0, Name = "Two-seater Sofa",
            Description = "Romantic pink for two"
        },
        new()
        {
            Id = 88, SaleCode = "carpet_polar*1", PageIds = new List<int> {12}, SortIndex = 6, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 62, SpecialSpriteId = 0, Name = "Pink Faux-Fur Bear Rug",
            Description = "Cute"
        },
        new()
        {
            Id = 89, SaleCode = "bed_polyfon_girl_one", PageIds = new List<int> {12}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 65, SpecialSpriteId = 0, Name = "Single Bed",
            Description = "Snuggle down in princess pink"
        },
        new()
        {
            Id = 90, SaleCode = "bed_polyfon_girl", PageIds = new List<int> {12}, SortIndex = 8, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 66, SpecialSpriteId = 0, Name = "Double Bed",
            Description = "Snuggle down in princess pink"
        },
        new()
        {
            Id = 91, SaleCode = "wall_china", PageIds = new List<int> {13}, SortIndex = 1, Price = 8, IsHidden = false,
            Amount = 1, DefinitionId = 207, SpecialSpriteId = 0, Name = "Dragon Screen",
            Description = "For your great wall"
        },
        new()
        {
            Id = 92, SaleCode = "corner_china", PageIds = new List<int> {13}, SortIndex = 2, Price = 8,
            IsHidden = false, Amount = 1, DefinitionId = 208, SpecialSpriteId = 0, Name = "Dragon Screen Corner",
            Description = "Firm, fireproof foundation"
        },
        new()
        {
            Id = 93, SaleCode = "china_shelve", PageIds = new List<int> {13}, SortIndex = 3, Price = 8,
            IsHidden = false, Amount = 1, DefinitionId = 204, SpecialSpriteId = 0, Name = "Chinese Bookshelf",
            Description = "To hold the mind's treasures"
        },
        new()
        {
            Id = 94, SaleCode = "chair_china", PageIds = new List<int> {13}, SortIndex = 4, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 201, SpecialSpriteId = 0, Name = "Chinese Lacquer Chair",
            Description = "The elegant beauty of tradition"
        },
        new()
        {
            Id = 95, SaleCode = "china_table", PageIds = new List<int> {13}, SortIndex = 5, Price = 6, IsHidden = false,
            Amount = 1, DefinitionId = 202, SpecialSpriteId = 0, Name = "Chinese Lacquer Table",
            Description = "Exotic and classy"
        },
        new()
        {
            Id = 96, SaleCode = "cn_sofa", PageIds = new List<int> {13}, SortIndex = 6, Price = 9, IsHidden = false,
            Amount = 1, DefinitionId = 186, SpecialSpriteId = 0, Name = "Chinese Sofa",
            Description = "Seats three with ease!"
        },
        new()
        {
            Id = 97, SaleCode = "poster 57", PageIds = new List<int> {13}, SortIndex = 7, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 57, Name = "Calligraphy poster",
            Description = "chinese calligraphy"
        },
        new()
        {
            Id = 98, SaleCode = "poster 58", PageIds = new List<int> {13}, SortIndex = 8, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 58, Name = "Red Knots", Description = "Wishing you luck"
        },
        new()
        {
            Id = 99, SaleCode = "cn_lamp", PageIds = new List<int> {13}, SortIndex = 9, Price = 9, IsHidden = false,
            Amount = 1, DefinitionId = 185, SpecialSpriteId = 0, Name = "Lantern", Description = "Light of the East"
        },
        new()
        {
            Id = 100, SaleCode = "chair_norja", PageIds = new List<int> {14}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 11, SpecialSpriteId = 0, Name = "Chair",
            Description = "Sleek and chic for each cheek"
        },
        new()
        {
            Id = 101, SaleCode = "couch_norja", PageIds = new List<int> {14}, SortIndex = 2, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 10, SpecialSpriteId = 0, Name = "Bench",
            Description = "Two can perch comfortably"
        },
        new()
        {
            Id = 102, SaleCode = "table_norja_med", PageIds = new List<int> {14}, SortIndex = 3, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 252, SpecialSpriteId = 0, Name = "Coffee Table",
            Description = "Elegance embodied"
        },
        new()
        {
            Id = 103, SaleCode = "shelves_norja", PageIds = new List<int> {14}, SortIndex = 4, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1, SpecialSpriteId = 0, Name = "Bookcase",
            Description = "For nic naks and art deco books"
        },
        new()
        {
            Id = 104, SaleCode = "soft_sofachair_norja", PageIds = new List<int> {14}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 95, SpecialSpriteId = 0, Name = "iced sofachair",
            Description = "Soft iced sofachair"
        },
        new()
        {
            Id = 105, SaleCode = "soft_sofa_norja", PageIds = new List<int> {14}, SortIndex = 6, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 96, SpecialSpriteId = 0, Name = "iced sofa",
            Description = "A soft iced sofa"
        },
        new()
        {
            Id = 106, SaleCode = "divider_nor2", PageIds = new List<int> {14}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 119, SpecialSpriteId = 0, Name = "Ice Bar-Desk",
            Description = "Strong, yet soft looking"
        },
        new()
        {
            Id = 107, SaleCode = "divider_nor1", PageIds = new List<int> {14}, SortIndex = 8, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 117, SpecialSpriteId = 0, Name = "Ice Corner",
            Description = "Looks squishy, but isn't"
        },
        new()
        {
            Id = 108, SaleCode = "divider_nor3", PageIds = new List<int> {14}, SortIndex = 9, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 121, SpecialSpriteId = 0, Name = "Door (Lockable)",
            Description = "Do go through..."
        },
        new()
        {
            Id = 109, SaleCode = "divider_nor4", PageIds = new List<int> {14}, SortIndex = 10, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 206, SpecialSpriteId = 0, Name = "Plain Iced Auto Shutter",
            Description = "Habbos, roll out!"
        },
        new()
        {
            Id = 110, SaleCode = "divider_nor5", PageIds = new List<int> {14}, SortIndex = 11, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 205, SpecialSpriteId = 0, Name = "Plain Iced Angle",
            Description = "Cool cornering for your crib y0!"
        },
        new()
        {
            Id = 111, SaleCode = "bed_armas_two", PageIds = new List<int> {15}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 22, SpecialSpriteId = 0, Name = "Double Bed",
            Description = "King-sized pine comfort"
        },
        new()
        {
            Id = 112, SaleCode = "bed_armas_one", PageIds = new List<int> {15}, SortIndex = 2, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 30, SpecialSpriteId = 0, Name = "Single Bed",
            Description = "Rustic charm for one"
        },
        new()
        {
            Id = 113, SaleCode = "fireplace_armas", PageIds = new List<int> {15}, SortIndex = 3, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 28, SpecialSpriteId = 0, Name = "Fireplace",
            Description = "Authentic, real flame fire"
        },
        new()
        {
            Id = 114, SaleCode = "bartable_armas", PageIds = new List<int> {15}, SortIndex = 4, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 51, SpecialSpriteId = 0, Name = "Bardesk",
            Description = "Bar-Style Table - essential for extra guests"
        },
        new()
        {
            Id = 115, SaleCode = "table_armas", PageIds = new List<int> {15}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 25, SpecialSpriteId = 0, Name = "Dining Table",
            Description = "For informal dining"
        },
        new()
        {
            Id = 116, SaleCode = "bench_armas", PageIds = new List<int> {15}, SortIndex = 6, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 24, SpecialSpriteId = 0, Name = "Bench",
            Description = "To complete the dining set"
        },
        new()
        {
            Id = 117, SaleCode = "divider_arm2", PageIds = new List<int> {15}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 115, SpecialSpriteId = 0, Name = "Room divider",
            Description = "I wooden go there"
        },
        new()
        {
            Id = 118, SaleCode = "divider_arm1", PageIds = new List<int> {15}, SortIndex = 8, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 114, SpecialSpriteId = 0, Name = "Corner plinth",
            Description = "Good solid wood"
        },
        new()
        {
            Id = 119, SaleCode = "divider_arm3", PageIds = new List<int> {15}, SortIndex = 9, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 116, SpecialSpriteId = 0, Name = "Gate (lockable)",
            Description = "Knock, knock..."
        },
        new()
        {
            Id = 120, SaleCode = "shelves_armas", PageIds = new List<int> {15}, SortIndex = 10, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 23, SpecialSpriteId = 0, Name = "Bookcase",
            Description = "For all those fire-side stories"
        },
        new()
        {
            Id = 121, SaleCode = "bar_armas", PageIds = new List<int> {15}, SortIndex = 11, Price = 4, IsHidden = false,
            Amount = 1, DefinitionId = 50, SpecialSpriteId = 0, Name = "Barrel Minibar",
            Description = "It's a barrel of laughs and a great talking point"
        },
        new()
        {
            Id = 122, SaleCode = "bar_chair_armas", PageIds = new List<int> {15}, SortIndex = 12, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 52, SpecialSpriteId = 0, Name = "Barrel Stool",
            Description = "The ultimate recycled furniture"
        },
        new()
        {
            Id = 123, SaleCode = "lamp_armas", PageIds = new List<int> {15}, SortIndex = 13, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 29, SpecialSpriteId = 0, Name = "Table Lamp",
            Description = "Ambient lighting is essential"
        },
        new()
        {
            Id = 124, SaleCode = "lamp2_armas", PageIds = new List<int> {15}, SortIndex = 14, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 98, SpecialSpriteId = 0, Name = "Lodge Candle",
            Description = "Wax lyrical with some old-world charm"
        },
        new()
        {
            Id = 125, SaleCode = "small_table_armas", PageIds = new List<int> {15}, SortIndex = 15, Price = 2,
            IsHidden = false, Amount = 1, DefinitionId = 26, SpecialSpriteId = 0, Name = "Occasional Table",
            Description = "Practical and beautiful"
        },
        new()
        {
            Id = 126, SaleCode = "small_chair_armas", PageIds = new List<int> {15}, SortIndex = 16, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 27, SpecialSpriteId = 0, Name = "Stool",
            Description = "Rustic charm at it's best"
        },
        new()
        {
            Id = 127, SaleCode = "bed_budgetb_one", PageIds = new List<int> {17}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 68, SpecialSpriteId = 0, Name = "Plain Single Bed",
            Description = "All you need for a good night's kip"
        },
        new()
        {
            Id = 128, SaleCode = "bed_budgetb", PageIds = new List<int> {17}, SortIndex = 2, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 69, SpecialSpriteId = 0, Name = "Plain Double Bed",
            Description = "Sweet dreams for two"
        },
        new()
        {
            Id = 129, SaleCode = "shelves_basic", PageIds = new List<int> {17}, SortIndex = 3, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 94, SpecialSpriteId = 0, Name = "Pura Shelves",
            Description = "Pura series 404 shelves"
        },
        new()
        {
            Id = 130, SaleCode = "bar_basic", PageIds = new List<int> {17}, SortIndex = 4, Price = 4, IsHidden = false,
            Amount = 1, DefinitionId = 93, SpecialSpriteId = 0, Name = "A Pura Minibar",
            Description = "A pura series 300 minibar"
        },
        new()
        {
            Id = 131, SaleCode = "fridge", PageIds = new List<int> {17}, SortIndex = 5, Price = 6, IsHidden = false,
            Amount = 1, DefinitionId = 99, SpecialSpriteId = 0, Name = "Pura Refridgerator",
            Description = "Keep cool with a chilled snack or drink"
        },
        new()
        {
            Id = 132, SaleCode = "lamp_basic", PageIds = new List<int> {17}, SortIndex = 6, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 97, SpecialSpriteId = 0, Name = "Pura Lamp",
            Description = "Switch on the atmosphere with this sophisticated light"
        },
        new()
        {
            Id = 133, SaleCode = "bed_polyfon", PageIds = new List<int> {18}, SortIndex = 1, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 17, SpecialSpriteId = 0, Name = "Double Bed",
            Description = "Give yourself space to stretch out"
        },
        new()
        {
            Id = 134, SaleCode = "bed_polyfon_one", PageIds = new List<int> {18}, SortIndex = 2, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 18, SpecialSpriteId = 0, Name = "Single Bed",
            Description = "Cot of the artistic"
        },
        new()
        {
            Id = 135, SaleCode = "fireplace_polyfon", PageIds = new List<int> {18}, SortIndex = 3, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 34, SpecialSpriteId = 0, Name = "Fireplace",
            Description = "Comfort in stainless steel"
        },
        new()
        {
            Id = 136, SaleCode = "sofachair_polyfon", PageIds = new List<int> {18}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 15, SpecialSpriteId = 0, Name = "Armchair",
            Description = "Soft and comfortable"
        },
        new()
        {
            Id = 137, SaleCode = "bar_polyfon", PageIds = new List<int> {18}, SortIndex = 6, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 45, SpecialSpriteId = 0, Name = "Mini-Bar",
            Description = "You naughty Habbo!"
        },
        new()
        {
            Id = 138, SaleCode = "bardesk_polyfon", PageIds = new List<int> {18}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 48, SpecialSpriteId = 0, Name = "Bar/desk",
            Description = "Perfect for work or play"
        },
        new()
        {
            Id = 139, SaleCode = "bardeskcorner_polyfon", PageIds = new List<int> {18}, SortIndex = 8, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 49, SpecialSpriteId = 0, Name = "Corner Cabinet/Desk",
            Description = "Tuck it away"
        },
        new()
        {
            Id = 140, SaleCode = "divider_poly3", PageIds = new List<int> {18}, SortIndex = 9, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 113, SpecialSpriteId = 0, Name = "Hatch (Lockable)",
            Description = "All bars should have one"
        },
        new()
        {
            Id = 141, SaleCode = "chair_polyfon", PageIds = new List<int> {18}, SortIndex = 10, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 5, SpecialSpriteId = 0, Name = "Dining Chair",
            Description = "Dining Chair"
        },
        new()
        {
            Id = 142, SaleCode = "smooth_table_polyfon", PageIds = new List<int> {18}, SortIndex = 12, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 63, SpecialSpriteId = 0, Name = "Large Dining Table",
            Description = "For larger gatherings"
        },
        new()
        {
            Id = 143, SaleCode = "table_polyfon_med", PageIds = new List<int> {18}, SortIndex = 13, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 12, SpecialSpriteId = 0, Name = "Large Coffee Table",
            Description = "For larger gatherings"
        },
        new()
        {
            Id = 144, SaleCode = "table_polyfon_small", PageIds = new List<int> {18}, SortIndex = 14, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 4, SpecialSpriteId = 0, Name = "Small Coffee Table",
            Description = "For serving a stylish latte"
        },
        new()
        {
            Id = 145, SaleCode = "shelves_polyfon", PageIds = new List<int> {18}, SortIndex = 15, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 2, SpecialSpriteId = 0, Name = "Bookcase",
            Description = "For the arty pad"
        },
        new()
        {
            Id = 146, SaleCode = "stand_polyfon_z", PageIds = new List<int> {18}, SortIndex = 16, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 7, SpecialSpriteId = 0, Name = "Shelf", Description = "Tidy up"
        },
        new()
        {
            Id = 147, SaleCode = "tv_luxus", PageIds = new List<int> {19}, SortIndex = 1, Price = 6, IsHidden = false,
            Amount = 1, DefinitionId = 83, SpecialSpriteId = 0, Name = "Digital TV", Description = "Bang up to date"
        },
        new()
        {
            Id = 148, SaleCode = "wood_tv", PageIds = new List<int> {19}, SortIndex = 2, Price = 4, IsHidden = false,
            Amount = 1, DefinitionId = 61, SpecialSpriteId = 0, Name = "Large TV", Description = "HNN weatherman Kiazie"
        },
        new()
        {
            Id = 149, SaleCode = "red_tv", PageIds = new List<int> {19}, SortIndex = 3, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 60, SpecialSpriteId = 0, Name = "Portable TV",
            Description = "Don?t miss those soaps"
        },
        new()
        {
            Id = 150, SaleCode = "A2 tlp 20", PageIds = new List<int> {19}, SortIndex = 4, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 244, SpecialSpriteId = 0, Name = "", Description = ""
        },
        new()
        {
            Id = 151, SaleCode = "pizza", PageIds = new List<int> {19}, SortIndex = 5, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 43, SpecialSpriteId = 0, Name = "Pizza Box", Description = "You dirty Habbo"
        },
        new()
        {
            Id = 152, SaleCode = "drinks", PageIds = new List<int> {19}, SortIndex = 6, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 44, SpecialSpriteId = 0, Name = "Empty Cans", Description = "Are you a slob too?"
        },
        new()
        {
            Id = 153, SaleCode = "bottle", PageIds = new List<int> {19}, SortIndex = 7, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 47, SpecialSpriteId = 0, Name = "Empty Spinning Bottle",
            Description = "For interesting games!"
        },
        new()
        {
            Id = 154, SaleCode = "edice", PageIds = new List<int> {19}, SortIndex = 8, Price = 6, IsHidden = false,
            Amount = 1, DefinitionId = 111, SpecialSpriteId = 0, Name = "Holo-dice",
            Description = "What's your lucky number?"
        },
        new()
        {
            Id = 155, SaleCode = "habbocake", PageIds = new List<int> {19}, SortIndex = 9, Price = 4, IsHidden = false,
            Amount = 1, DefinitionId = 109, SpecialSpriteId = 0, Name = "Cake", Description = "Save me a slice!"
        },
        new()
        {
            Id = 156, SaleCode = "menorah", PageIds = new List<int> {19}, SortIndex = 10, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 103, SpecialSpriteId = 0, Name = "Menorah", Description = "Light up your room"
        },
        new()
        {
            Id = 157, SaleCode = "bunny", PageIds = new List<int> {19}, SortIndex = 11, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 110, SpecialSpriteId = 0, Name = "Squidgy Bunny",
            Description = "Yours to cuddle up to"
        },
        new()
        {
            Id = 158, SaleCode = "poster 44", PageIds = new List<int> {19}, SortIndex = 12, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 44, Name = "Mummy", Description = "Beware the curse..."
        },
        new()
        {
            Id = 159, SaleCode = "wcandleset", PageIds = new List<int> {19}, SortIndex = 13, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 105, SpecialSpriteId = 0, Name = "White Candle Plate",
            Description = "Simple but stylish"
        },
        new()
        {
            Id = 160, SaleCode = "rcandleset", PageIds = new List<int> {19}, SortIndex = 14, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 106, SpecialSpriteId = 0, Name = "Red Candle Plate",
            Description = "Simple but stylish"
        },
        new()
        {
            Id = 161, SaleCode = "ham", PageIds = new List<int> {19}, SortIndex = 15, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 104, SpecialSpriteId = 0, Name = "Joint of Ham", Description = "Tuck in"
        },
        new()
        {
            Id = 162, SaleCode = "hockey_light", PageIds = new List<int> {19}, SortIndex = 16, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 131, SpecialSpriteId = 0, Name = "Lert",
            Description = "Set it off."
        },
        new()
        {
            Id = 163, SaleCode = "bath", PageIds = new List<int> {20}, SortIndex = 1, Price = 6, IsHidden = false,
            Amount = 1, DefinitionId = 84, SpecialSpriteId = 0, Name = "Bubble Bath",
            Description = "The ultimate in pampering"
        },
        new()
        {
            Id = 164, SaleCode = "sink", PageIds = new List<int> {20}, SortIndex = 2, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 85, SpecialSpriteId = 0, Name = "Sink",
            Description = "Hot and cold thrown in for no charge"
        },
        new()
        {
            Id = 165, SaleCode = "duck", PageIds = new List<int> {20}, SortIndex = 3, Price = 1, IsHidden = false,
            Amount = 1, DefinitionId = 87, SpecialSpriteId = 0, Name = "Rubber Duck",
            Description = "Every bather needs one"
        },
        new()
        {
            Id = 166, SaleCode = "toilet", PageIds = new List<int> {20}, SortIndex = 4, Price = 4, IsHidden = false,
            Amount = 1, DefinitionId = 86, SpecialSpriteId = 0, Name = "Loo Seat", Description = "Loo Seat"
        },
        new()
        {
            Id = 167, SaleCode = "toilet_red", PageIds = new List<int> {20}, SortIndex = 5, Price = 4, IsHidden = false,
            Amount = 1, DefinitionId = 89, SpecialSpriteId = 0, Name = "Loo Seat", Description = "Loo Seat"
        },
        new()
        {
            Id = 168, SaleCode = "toilet_yell", PageIds = new List<int> {20}, SortIndex = 6, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 90, SpecialSpriteId = 0, Name = "Loo Seat",
            Description = "Loo Seat"
        },
        new()
        {
            Id = 169, SaleCode = "tile", PageIds = new List<int> {20}, SortIndex = 7, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 88, SpecialSpriteId = 0, Name = "Floor Tiles",
            Description = "In a choice of colours"
        },
        new()
        {
            Id = 170, SaleCode = "tile_red", PageIds = new List<int> {20}, SortIndex = 8, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 91, SpecialSpriteId = 0, Name = "Floor Tiles",
            Description = "In a choice of colours"
        },
        new()
        {
            Id = 171, SaleCode = "tile_yell", PageIds = new List<int> {20}, SortIndex = 9, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 92, SpecialSpriteId = 0, Name = "Floor Tiles",
            Description = "In a choice of colours"
        },
        new()
        {
            Id = 172, SaleCode = "giftflowers", PageIds = new List<int> {21}, SortIndex = 1, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 108, SpecialSpriteId = 0, Name = "Vase of Flowers",
            Description = "Guaranteed to stay fresh"
        },
        new()
        {
            Id = 173, SaleCode = "plant_rose", PageIds = new List<int> {21}, SortIndex = 2, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 82, SpecialSpriteId = 0, Name = "Cut Roses", Description = "Sleek and chic"
        },
        new()
        {
            Id = 174, SaleCode = "plant_sunflower", PageIds = new List<int> {21}, SortIndex = 3, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 81, SpecialSpriteId = 0, Name = "Cut Sunflower",
            Description = "For happy Habbos"
        },
        new()
        {
            Id = 175, SaleCode = "plant_yukka", PageIds = new List<int> {21}, SortIndex = 4, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 75, SpecialSpriteId = 0, Name = "Yukka Plant",
            Description = "Easy to care for"
        },
        new()
        {
            Id = 176, SaleCode = "plant_pineapple", PageIds = new List<int> {21}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 70, SpecialSpriteId = 0, Name = "Pineapple Plant",
            Description = "Needs loving glances"
        },
        new()
        {
            Id = 177, SaleCode = "plant_bonsai", PageIds = new List<int> {21}, SortIndex = 6, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 73, SpecialSpriteId = 0, Name = "Bonsai Tree",
            Description = "You can be sure it lives"
        },
        new()
        {
            Id = 178, SaleCode = "plant_big_cactus", PageIds = new List<int> {21}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 74, SpecialSpriteId = 0, Name = "Mature Cactus",
            Description = "Habbo Dreams monster in hiding!  Shhhh"
        },
        new()
        {
            Id = 179, SaleCode = "plant_small_cactus", PageIds = new List<int> {21}, SortIndex = 8, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 72, SpecialSpriteId = 0, Name = "Small Cactus",
            Description = "Even less watering than the real world"
        },
        new()
        {
            Id = 180, SaleCode = "plant_fruittree", PageIds = new List<int> {21}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 71, SpecialSpriteId = 0, Name = "Fruit Tree",
            Description = "Great yield and sweet fruit"
        },
        new()
        {
            Id = 181, SaleCode = "plant_bulrush", PageIds = new List<int> {21}, SortIndex = 10, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 235, SpecialSpriteId = 0, Name = "Bulrush",
            Description = "Ideal for the riverside"
        },
        new()
        {
            Id = 182, SaleCode = "plant_cruddy", PageIds = new List<int> {21}, SortIndex = 11, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 46, SpecialSpriteId = 0, Name = "Aloe Vera",
            Description = "Goodbye Bert..."
        },
        new()
        {
            Id = 183, SaleCode = "plant_maze", PageIds = new List<int> {21}, SortIndex = 12, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 234, SpecialSpriteId = 0, Name = "Maze Shrubbery",
            Description = "Build your maze!"
        },
        new()
        {
            Id = 184, SaleCode = "plant_mazegate", PageIds = new List<int> {21}, SortIndex = 13, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 233, SpecialSpriteId = 0, Name = "Maze Shrubbery Gate",
            Description = "Did we make it?"
        },
        new()
        {
            Id = 186, SaleCode = "poster 52", PageIds = new List<int> {22}, SortIndex = 1, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 52, Name = "Hockey Stick",
            Description = "whack that ball!"
        },
        new()
        {
            Id = 187, SaleCode = "poster 53", PageIds = new List<int> {22}, SortIndex = 2, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 53, Name = "Hockey Stick",
            Description = "whack that ball!"
        },
        new()
        {
            Id = 188, SaleCode = "poster 54", PageIds = new List<int> {22}, SortIndex = 3, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 54, Name = "Hockey Stick",
            Description = "whack that ball!"
        },
        new()
        {
            Id = 189, SaleCode = "hockey_score", PageIds = new List<int> {22}, SortIndex = 4, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 130, SpecialSpriteId = 0, Name = "Scoreboard",
            Description = "...for keeping your score"
        },
        new()
        {
            Id = 190, SaleCode = "legotrophy", PageIds = new List<int> {22}, SortIndex = 5, Price = 6, IsHidden = false,
            Amount = 1, DefinitionId = 126, SpecialSpriteId = 0, Name = "Basketball Trophy",
            Description = "For the winning team"
        },
        new()
        {
            Id = 191, SaleCode = "poster 51", PageIds = new List<int> {22}, SortIndex = 6, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 51, Name = "Basketball Hoop",
            Description = "2 points for every basket"
        },
        new()
        {
            Id = 192, SaleCode = "carpet_legocourt", PageIds = new List<int> {22}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 124, SpecialSpriteId = 0, Name = "Basketball Court",
            Description = "Line up your slam dunk"
        },
        new()
        {
            Id = 193, SaleCode = "bench_lego", PageIds = new List<int> {22}, SortIndex = 8, Price = 6, IsHidden = false,
            Amount = 1, DefinitionId = 125, SpecialSpriteId = 0, Name = "Team Bench",
            Description = "For your reserve players"
        },
        new()
        {
            Id = 194, SaleCode = "sporttrack1*1", PageIds = new List<int> {22}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 187, SpecialSpriteId = 0, Name = "Sport track straight",
            Description = "Let's get sporty!"
        },
        new()
        {
            Id = 195, SaleCode = "sporttrack1*2", PageIds = new List<int> {22}, SortIndex = 12, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 189, SpecialSpriteId = 0,
            Name = "Sport track straight asphalt", Description = "Let's get sporty!"
        },
        new()
        {
            Id = 196, SaleCode = "sporttrack1*3", PageIds = new List<int> {22}, SortIndex = 15, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 188, SpecialSpriteId = 0, Name = "Sport track straight grass",
            Description = "Let's get sporty!"
        },
        new()
        {
            Id = 197, SaleCode = "sporttrack2*1", PageIds = new List<int> {22}, SortIndex = 10, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 190, SpecialSpriteId = 0, Name = "Sport corner tartan",
            Description = "Let's get sporty!"
        },
        new()
        {
            Id = 198, SaleCode = "sporttrack2*2", PageIds = new List<int> {22}, SortIndex = 13, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 191, SpecialSpriteId = 0, Name = "Sport corner asphalt",
            Description = "Let's get sporty!"
        },
        new()
        {
            Id = 199, SaleCode = "sporttrack2*3", PageIds = new List<int> {22}, SortIndex = 16, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 192, SpecialSpriteId = 0, Name = "Sport corner grass",
            Description = "Let's get sporty!"
        },
        new()
        {
            Id = 200, SaleCode = "sporttrack3*1", PageIds = new List<int> {22}, SortIndex = 11, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 193, SpecialSpriteId = 0, Name = "Sport goal tartan",
            Description = "Let's get sporty!"
        },
        new()
        {
            Id = 201, SaleCode = "sporttrack3*2", PageIds = new List<int> {22}, SortIndex = 14, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 194, SpecialSpriteId = 0, Name = "Sport goal asphalt",
            Description = "Let's get sporty!"
        },
        new()
        {
            Id = 202, SaleCode = "sporttrack3*3", PageIds = new List<int> {22}, SortIndex = 17, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 195, SpecialSpriteId = 0, Name = "Sport goal grass",
            Description = "Let's get sporty!"
        },
        new()
        {
            Id = 203, SaleCode = "footylamp", PageIds = new List<int> {22}, SortIndex = 18, Price = 4, IsHidden = false,
            Amount = 1, DefinitionId = 196, SpecialSpriteId = 0, Name = "Football Lamp",
            Description = "Can you kick it?"
        },
        new()
        {
            Id = 204, SaleCode = "carpet_standard*4", PageIds = new List<int> {23}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 39, SpecialSpriteId = 0, Name = "Floor Rug",
            Description = "Available in a variety of colours"
        },
        new()
        {
            Id = 205, SaleCode = "carpet_standard*5", PageIds = new List<int> {23}, SortIndex = 2, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 41, SpecialSpriteId = 0, Name = "Floor Rug",
            Description = "Available in a variety of colours"
        },
        new()
        {
            Id = 206, SaleCode = "carpet_standard", PageIds = new List<int> {23}, SortIndex = 3, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 31, SpecialSpriteId = 0, Name = "Floor rug",
            Description = "Available in a variety of colours"
        },
        new()
        {
            Id = 207, SaleCode = "carpet_standard*b", PageIds = new List<int> {23}, SortIndex = 4, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 80, SpecialSpriteId = 0, Name = "Floor Rug",
            Description = "Available in a variety of colours"
        },
        new()
        {
            Id = 208, SaleCode = "carpet_standard*a", PageIds = new List<int> {23}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 79, SpecialSpriteId = 0, Name = "Floor Rug",
            Description = "Available in a variety of colours"
        },
        new()
        {
            Id = 209, SaleCode = "carpet_standard*3", PageIds = new List<int> {23}, SortIndex = 6, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 38, SpecialSpriteId = 0, Name = "Floor Rug",
            Description = "Available in a variety of colours"
        },
        new()
        {
            Id = 210, SaleCode = "carpet_standard*2", PageIds = new List<int> {23}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 37, SpecialSpriteId = 0, Name = "Floor Rug",
            Description = "Available in a variety of colours"
        },
        new()
        {
            Id = 211, SaleCode = "carpet_standard*8", PageIds = new List<int> {23}, SortIndex = 8, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 77, SpecialSpriteId = 0, Name = "Floor Rug",
            Description = "Available in a variety of colours"
        },
        new()
        {
            Id = 212, SaleCode = "carpet_standard*7", PageIds = new List<int> {23}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 76, SpecialSpriteId = 0, Name = "Floor Rug",
            Description = "Available in a variety of colours"
        },
        new()
        {
            Id = 213, SaleCode = "carpet_standard*1", PageIds = new List<int> {23}, SortIndex = 10, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 35, SpecialSpriteId = 0, Name = "Floor Rug",
            Description = "Available in a variety of colours"
        },
        new()
        {
            Id = 214, SaleCode = "carpet_standard*6", PageIds = new List<int> {23}, SortIndex = 11, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 42, SpecialSpriteId = 0, Name = "Floor Rug",
            Description = "Available in a variety of colours"
        },
        new()
        {
            Id = 215, SaleCode = "carpet_standard*9", PageIds = new List<int> {23}, SortIndex = 12, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 78, SpecialSpriteId = 0, Name = "", Description = ""
        },
        new()
        {
            Id = 216, SaleCode = "carpet_soft", PageIds = new List<int> {23}, SortIndex = 13, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 53, SpecialSpriteId = 0, Name = "Soft Wool Rug",
            Description = "Soft Wool Rug"
        },
        new()
        {
            Id = 217, SaleCode = "carpet_soft*1", PageIds = new List<int> {23}, SortIndex = 14, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 54, SpecialSpriteId = 0, Name = "Soft Wool Rug",
            Description = "Soft Wool Rug"
        },
        new()
        {
            Id = 218, SaleCode = "carpet_soft*2", PageIds = new List<int> {23}, SortIndex = 15, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 55, SpecialSpriteId = 0, Name = "Soft Wool Rug",
            Description = "Soft Wool Rug"
        },
        new()
        {
            Id = 219, SaleCode = "carpet_soft*3", PageIds = new List<int> {23}, SortIndex = 16, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 56, SpecialSpriteId = 0, Name = "Soft Wool Rug",
            Description = "Soft Wool Rug"
        },
        new()
        {
            Id = 220, SaleCode = "carpet_soft*4", PageIds = new List<int> {23}, SortIndex = 17, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 57, SpecialSpriteId = 0, Name = "Soft Wool Rug",
            Description = "Soft Wool Rug"
        },
        new()
        {
            Id = 221, SaleCode = "carpet_soft*5", PageIds = new List<int> {23}, SortIndex = 18, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 58, SpecialSpriteId = 0, Name = "Soft Wool Rug",
            Description = "Soft Wool Rug"
        },
        new()
        {
            Id = 222, SaleCode = "carpet_soft*6", PageIds = new List<int> {23}, SortIndex = 19, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 59, SpecialSpriteId = 0, Name = "Soft Wool Rug",
            Description = "Soft Wool Rug"
        },
        new()
        {
            Id = 223, SaleCode = "doormat_love", PageIds = new List<int> {23}, SortIndex = 20, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 13, SpecialSpriteId = 0, Name = "Doormat",
            Description = "Welcome Habbos in style"
        },
        new()
        {
            Id = 224, SaleCode = "doormat_plain", PageIds = new List<int> {23}, SortIndex = 21, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 14, SpecialSpriteId = 0, Name = "Doormat",
            Description = "Available in a variety of colours"
        },
        new()
        {
            Id = 225, SaleCode = "doormat_plain*1", PageIds = new List<int> {23}, SortIndex = 22, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 36, SpecialSpriteId = 0, Name = "Doormat",
            Description = "Available in a variety of colours"
        },
        new()
        {
            Id = 226, SaleCode = "doormat_plain*2", PageIds = new List<int> {23}, SortIndex = 23, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 254, SpecialSpriteId = 0, Name = "Doormat",
            Description = "Available in a variety of colours"
        },
        new()
        {
            Id = 227, SaleCode = "doormat_plain*3", PageIds = new List<int> {23}, SortIndex = 24, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 255, SpecialSpriteId = 0, Name = "Doormat",
            Description = "Available in a variety of colours"
        },
        new()
        {
            Id = 228, SaleCode = "doormat_plain*4", PageIds = new List<int> {23}, SortIndex = 25, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 253, SpecialSpriteId = 0, Name = "Doormat",
            Description = "Available in a variety of colours"
        },
        new()
        {
            Id = 229, SaleCode = "doormat_plain*5", PageIds = new List<int> {23}, SortIndex = 26, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 256, SpecialSpriteId = 0, Name = "Doormat",
            Description = "Available in a variety of colours"
        },
        new()
        {
            Id = 230, SaleCode = "doormat_plain*6", PageIds = new List<int> {23}, SortIndex = 27, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 40, SpecialSpriteId = 0, Name = "Doormat",
            Description = "Available in a variety of colours"
        },
        new()
        {
            Id = 231, SaleCode = "carpet_armas", PageIds = new List<int> {23}, SortIndex = 28, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 32, SpecialSpriteId = 0, Name = "Hand-Woven Rug",
            Description = "Adds instant warmth"
        },
        new()
        {
            Id = 232, SaleCode = "carpet_polar", PageIds = new List<int> {23}, SortIndex = 29, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 33, SpecialSpriteId = 0, Name = "Faux-Fur Bear Rug",
            Description = "For cuddling up on"
        },
        new()
        {
            Id = 233, SaleCode = "prizetrophy2*3", PageIds = new List<int> {26}, SortIndex = 1, Price = 8,
            IsHidden = false, Amount = 1, DefinitionId = 133, SpecialSpriteId = 0, Name = "Duck trophy",
            Description = "Breathtaking bronze"
        },
        new()
        {
            Id = 234, SaleCode = "prizetrophy3*3", PageIds = new List<int> {26}, SortIndex = 2, Price = 8,
            IsHidden = false, Amount = 1, DefinitionId = 134, SpecialSpriteId = 0, Name = "Globe trophy",
            Description = "Breathtaking bronze"
        },
        new()
        {
            Id = 235, SaleCode = "prizetrophy4*3", PageIds = new List<int> {26}, SortIndex = 3, Price = 8,
            IsHidden = false, Amount = 1, DefinitionId = 135, SpecialSpriteId = 0, Name = "Fish trophy",
            Description = "Breathtaking bronze"
        },
        new()
        {
            Id = 236, SaleCode = "prizetrophy5*3", PageIds = new List<int> {26}, SortIndex = 4, Price = 8,
            IsHidden = false, Amount = 1, DefinitionId = 136, SpecialSpriteId = 0, Name = "Duo trophy",
            Description = "Breathtaking bronze"
        },
        new()
        {
            Id = 237, SaleCode = "prizetrophy6*3", PageIds = new List<int> {26}, SortIndex = 5, Price = 8,
            IsHidden = false, Amount = 1, DefinitionId = 137, SpecialSpriteId = 0, Name = "Champion trophy",
            Description = "Breathtaking bronze"
        },
        new()
        {
            Id = 238, SaleCode = "prizetrophy*3", PageIds = new List<int> {26}, SortIndex = 6, Price = 8,
            IsHidden = false, Amount = 1, DefinitionId = 149, SpecialSpriteId = 0, Name = "Classic trophy",
            Description = "Breathtaking bronze"
        },
        new()
        {
            Id = 239, SaleCode = "prizetrophy2*2", PageIds = new List<int> {26}, SortIndex = 7, Price = 10,
            IsHidden = false, Amount = 1, DefinitionId = 144, SpecialSpriteId = 0, Name = "Duck trophy",
            Description = "Shiny silver"
        },
        new()
        {
            Id = 240, SaleCode = "prizetrophy3*2", PageIds = new List<int> {26}, SortIndex = 8, Price = 10,
            IsHidden = false, Amount = 1, DefinitionId = 145, SpecialSpriteId = 0, Name = "Globe trophy",
            Description = "Shiny silver"
        },
        new()
        {
            Id = 241, SaleCode = "prizetrophy4*2", PageIds = new List<int> {26}, SortIndex = 9, Price = 10,
            IsHidden = false, Amount = 1, DefinitionId = 146, SpecialSpriteId = 0, Name = "Fish trophy",
            Description = "Shiny silver"
        },
        new()
        {
            Id = 242, SaleCode = "prizetrophy5*2", PageIds = new List<int> {26}, SortIndex = 10, Price = 10,
            IsHidden = false, Amount = 1, DefinitionId = 147, SpecialSpriteId = 0, Name = "Duo trophy",
            Description = "Shiny silver"
        },
        new()
        {
            Id = 243, SaleCode = "prizetrophy6*2", PageIds = new List<int> {26}, SortIndex = 11, Price = 10,
            IsHidden = false, Amount = 1, DefinitionId = 148, SpecialSpriteId = 0, Name = "Champion trophy",
            Description = "Shiny silver"
        },
        new()
        {
            Id = 244, SaleCode = "prizetrophy*2", PageIds = new List<int> {26}, SortIndex = 12, Price = 10,
            IsHidden = false, Amount = 1, DefinitionId = 143, SpecialSpriteId = 0, Name = "Classic trophy",
            Description = "Shiny silver"
        },
        new()
        {
            Id = 245, SaleCode = "prizetrophy2*1", PageIds = new List<int> {26}, SortIndex = 13, Price = 12,
            IsHidden = false, Amount = 1, DefinitionId = 138, SpecialSpriteId = 0, Name = "Duck trophy",
            Description = "Glittery gold"
        },
        new()
        {
            Id = 246, SaleCode = "prizetrophy3*1", PageIds = new List<int> {26}, SortIndex = 14, Price = 12,
            IsHidden = false, Amount = 1, DefinitionId = 139, SpecialSpriteId = 0, Name = "Globe trophy",
            Description = "Glittery gold"
        },
        new()
        {
            Id = 247, SaleCode = "prizetrophy4*1", PageIds = new List<int> {26}, SortIndex = 15, Price = 12,
            IsHidden = false, Amount = 1, DefinitionId = 140, SpecialSpriteId = 0, Name = "Fish trophy",
            Description = "Glittery gold"
        },
        new()
        {
            Id = 248, SaleCode = "prizetrophy5*1", PageIds = new List<int> {26}, SortIndex = 16, Price = 12,
            IsHidden = false, Amount = 1, DefinitionId = 141, SpecialSpriteId = 0, Name = "Duo trophy",
            Description = "Glittery gold"
        },
        new()
        {
            Id = 249, SaleCode = "prizetrophy6*3", PageIds = new List<int> {26}, SortIndex = 17, Price = 12,
            IsHidden = false, Amount = 1, DefinitionId = 137, SpecialSpriteId = 0, Name = "Champion trophy",
            Description = "Breathtaking bronze"
        },
        new()
        {
            Id = 250, SaleCode = "prizetrophy6*1", PageIds = new List<int> {26}, SortIndex = 18, Price = 12,
            IsHidden = false, Amount = 1, DefinitionId = 142, SpecialSpriteId = 0, Name = "Champion trophy",
            Description = "Glittery gold"
        },
        new()
        {
            Id = 251, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 2, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 1, Name = "", Description = ""
        },
        new()
        {
            Id = 252, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 3, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 2, Name = "", Description = ""
        },
        new()
        {
            Id = 253, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 4, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 3, Name = "", Description = ""
        },
        new()
        {
            Id = 254, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 5, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 4, Name = "", Description = ""
        },
        new()
        {
            Id = 255, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 6, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 5, Name = "", Description = ""
        },
        new()
        {
            Id = 256, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 7, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 6, Name = "", Description = ""
        },
        new()
        {
            Id = 257, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 8, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 7, Name = "", Description = ""
        },
        new()
        {
            Id = 258, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 9, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 8, Name = "", Description = ""
        },
        new()
        {
            Id = 259, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 10, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 9, Name = "", Description = ""
        },
        new()
        {
            Id = 260, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 11, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 10, Name = "", Description = ""
        },
        new()
        {
            Id = 261, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 12, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 11, Name = "", Description = ""
        },
        new()
        {
            Id = 262, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 13, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 12, Name = "", Description = ""
        },
        new()
        {
            Id = 263, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 14, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 13, Name = "", Description = ""
        },
        new()
        {
            Id = 264, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 15, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 14, Name = "", Description = ""
        },
        new()
        {
            Id = 265, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 16, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 15, Name = "", Description = ""
        },
        new()
        {
            Id = 266, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 17, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 16, Name = "", Description = ""
        },
        new()
        {
            Id = 267, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 18, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 17, Name = "", Description = ""
        },
        new()
        {
            Id = 268, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 19, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 18, Name = "", Description = ""
        },
        new()
        {
            Id = 269, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 20, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 19, Name = "", Description = ""
        },
        new()
        {
            Id = 270, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 21, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 20, Name = "", Description = ""
        },
        new()
        {
            Id = 271, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 22, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 21, Name = "", Description = ""
        },
        new()
        {
            Id = 272, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 23, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 22, Name = "", Description = ""
        },
        new()
        {
            Id = 273, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 24, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 23, Name = "", Description = ""
        },
        new()
        {
            Id = 274, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 25, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 24, Name = "", Description = ""
        },
        new()
        {
            Id = 275, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 26, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 25, Name = "", Description = ""
        },
        new()
        {
            Id = 276, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 27, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 26, Name = "", Description = ""
        },
        new()
        {
            Id = 277, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 28, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 27, Name = "", Description = ""
        },
        new()
        {
            Id = 278, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 29, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 28, Name = "", Description = ""
        },
        new()
        {
            Id = 279, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 30, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 29, Name = "", Description = ""
        },
        new()
        {
            Id = 280, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 31, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 30, Name = "", Description = ""
        },
        new()
        {
            Id = 281, SaleCode = "wallpaper", PageIds = new List<int> {3}, SortIndex = 32, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 250, SpecialSpriteId = 31, Name = "", Description = ""
        },
        new()
        {
            Id = 282, SaleCode = "poster 7", PageIds = new List<int> {24}, SortIndex = 1, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 7, Name = "Hammer Cabinet",
            Description = "For emergencies only"
        },
        new()
        {
            Id = 283, SaleCode = "poster 18", PageIds = new List<int> {24}, SortIndex = 2, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 18, Name = "Butterfly Cabinet 2",
            Description = "Beautiful reproduction butterfly"
        },
        new()
        {
            Id = 284, SaleCode = "poster 17", PageIds = new List<int> {24}, SortIndex = 3, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 17, Name = "Butterfly Cabinet 1",
            Description = "Beautiful reproduction butterfly"
        },
        new()
        {
            Id = 285, SaleCode = "poster 4", PageIds = new List<int> {24}, SortIndex = 4, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 4, Name = "Bear Plaque", Description = "Fake of course!"
        },
        new()
        {
            Id = 286, SaleCode = "poster 3", PageIds = new List<int> {24}, SortIndex = 5, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 3, Name = "Fish Plaque",
            Description = "Smells fishy, looks cool"
        },
        new()
        {
            Id = 287, SaleCode = "poster 2", PageIds = new List<int> {24}, SortIndex = 6, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 2, Name = "Carrot Plaque",
            Description = "Take pride in your veg!"
        },
        new()
        {
            Id = 288, SaleCode = "poster 10", PageIds = new List<int> {24}, SortIndex = 7, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 10, Name = "Lapland Poster",
            Description = "Beautiful sunset"
        },
        new()
        {
            Id = 289, SaleCode = "poster 15", PageIds = new List<int> {24}, SortIndex = 8, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 15, Name = "Himalayas Poster",
            Description = "Marvellous mountains"
        },
        new()
        {
            Id = 290, SaleCode = "poster 9", PageIds = new List<int> {24}, SortIndex = 9, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 9, Name = "Rainforest Poster",
            Description = "Do your bit for the environment"
        },
        new()
        {
            Id = 291, SaleCode = "poster 8", PageIds = new List<int> {24}, SortIndex = 10, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 8, Name = "Habbo Colours",
            Description = "Habbos come in all colours"
        },
        new()
        {
            Id = 292, SaleCode = "poster 19", PageIds = new List<int> {24}, SortIndex = 11, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 19, Name = "Hole In The Wall",
            Description = "Trying to get in or out?"
        },
        new()
        {
            Id = 293, SaleCode = "poster 16", PageIds = new List<int> {24}, SortIndex = 12, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 16, Name = "Bars", Description = "Added security"
        },
        new()
        {
            Id = 294, SaleCode = "poster 5", PageIds = new List<int> {24}, SortIndex = 13, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 5, Name = "Duck Poster",
            Description = "Quacking good design!"
        },
        new()
        {
            Id = 295, SaleCode = "poster 6", PageIds = new List<int> {24}, SortIndex = 14, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 6, Name = "Abstract Poster",
            Description = "But is it the right way up?"
        },
        new()
        {
            Id = 296, SaleCode = "poster 32", PageIds = new List<int> {24}, SortIndex = 15, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 32, Name = "Siva Poster",
            Description = "The Auspicious One"
        },
        new()
        {
            Id = 297, SaleCode = "poster 1", PageIds = new List<int> {24}, SortIndex = 16, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 1, Name = "Lady Lisa", Description = "Is she smiling?"
        },
        new()
        {
            Id = 298, SaleCode = "poster 14", PageIds = new List<int> {24}, SortIndex = 17, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 14, Name = "Fox Poster",
            Description = "A cunning painting"
        },
        new()
        {
            Id = 299, SaleCode = "poster 55", PageIds = new List<int> {24}, SortIndex = 18, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 55, Name = "Tree of Time", Description = "Save our trees!"
        },
        new()
        {
            Id = 300, SaleCode = "poster 33", PageIds = new List<int> {24}, SortIndex = 19, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 33, Name = "Save the Panda",
            Description = "We can't bear to lose them"
        },
        new()
        {
            Id = 301, SaleCode = "poster 11", PageIds = new List<int> {24}, SortIndex = 20, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 11, Name = "Certificate",
            Description = "I obey the Habbo way!"
        },
        new()
        {
            Id = 302, SaleCode = "poster 511", PageIds = new List<int> {25}, SortIndex = 1, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 511, Name = "The Dutch flag",
            Description = "The flag of The Netherlands"
        },
        new()
        {
            Id = 303, SaleCode = "poster 502", PageIds = new List<int> {25}, SortIndex = 2, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 502, Name = "The Stars and Stripes",
            Description = "The US flag"
        },
        new()
        {
            Id = 304, SaleCode = "poster 513", PageIds = new List<int> {25}, SortIndex = 3, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 513, Name = "The Australian flag",
            Description = "Aussies rule!"
        },
        new()
        {
            Id = 305, SaleCode = "poster 521", PageIds = new List<int> {25}, SortIndex = 4, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 521, Name = "Flag of Brazil",
            Description = "Ordem e progresso"
        },
        new()
        {
            Id = 306, SaleCode = "poster 505", PageIds = new List<int> {25}, SortIndex = 5, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 505, Name = "The Maple Leaf",
            Description = "The Canadian flag"
        },
        new()
        {
            Id = 307, SaleCode = "poster 504", PageIds = new List<int> {25}, SortIndex = 6, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 504, Name = "The Bundesflagge",
            Description = "The German flag"
        },
        new()
        {
            Id = 308, SaleCode = "poster 516", PageIds = new List<int> {25}, SortIndex = 7, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 516, Name = "The English flag",
            Description = "Eng-er-land"
        },
        new()
        {
            Id = 309, SaleCode = "poster 507", PageIds = new List<int> {25}, SortIndex = 8, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 507, Name = "The French Tricolore",
            Description = "The French flag"
        },
        new()
        {
            Id = 310, SaleCode = "poster 512", PageIds = new List<int> {25}, SortIndex = 9, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 251, SpecialSpriteId = 512, Name = "The Irish flag",
            Description = "The flag of Ireland"
        },
        new()
        {
            Id = 311, SaleCode = "poster 523", PageIds = new List<int> {25}, SortIndex = 10, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 523, Name = "India Flag",
            Description = "The flag of India"
        },
        new()
        {
            Id = 312, SaleCode = "poster 509", PageIds = new List<int> {25}, SortIndex = 11, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 509, Name = "The Jamaican flag",
            Description = "The flag of Jamaica"
        },
        new()
        {
            Id = 313, SaleCode = "poster 522", PageIds = new List<int> {25}, SortIndex = 12, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 522, Name = "Japan Flag",
            Description = "Land of the rising sun"
        },
        new()
        {
            Id = 314, SaleCode = "poster 520", PageIds = new List<int> {25}, SortIndex = 13, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 520, Name = "The Rainbow Flag",
            Description = "Every colour for everyone"
        },
        new()
        {
            Id = 315, SaleCode = "poster 517", PageIds = new List<int> {25}, SortIndex = 14, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 517, Name = "The Scottish flag",
            Description = "Where's your kilt?"
        },
        new()
        {
            Id = 316, SaleCode = "poster 508", PageIds = new List<int> {25}, SortIndex = 15, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 508, Name = "The Spanish flag",
            Description = "The flag of Spain"
        },
        new()
        {
            Id = 317, SaleCode = "poster 514", PageIds = new List<int> {25}, SortIndex = 16, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 514, Name = "The EU flag",
            Description = "Be proud to be in the Union!"
        },
        new()
        {
            Id = 318, SaleCode = "poster 506", PageIds = new List<int> {25}, SortIndex = 17, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 506, Name = "The flag of Finland",
            Description = "To 'Finnish' your decor..."
        },
        new()
        {
            Id = 319, SaleCode = "poster 510", PageIds = new List<int> {25}, SortIndex = 18, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 510, Name = "The Italian flag",
            Description = "The flag of Italy"
        },
        new()
        {
            Id = 320, SaleCode = "poster 518", PageIds = new List<int> {25}, SortIndex = 19, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 518, Name = "The Welsh flag",
            Description = "A fiery dragon for your wall"
        },
        new()
        {
            Id = 321, SaleCode = "poster 515", PageIds = new List<int> {25}, SortIndex = 20, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 515, Name = "The Swedish flag",
            Description = "Waved by Swedes everywhere"
        },
        new()
        {
            Id = 322, SaleCode = "poster 503", PageIds = new List<int> {25}, SortIndex = 21, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 503, Name = "The Swiss flag",
            Description = "There's no holes in this..."
        },
        new()
        {
            Id = 323, SaleCode = "poster 500", PageIds = new List<int> {25}, SortIndex = 22, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 500, Name = "Union Jack",
            Description = "The UK flag"
        },
        new()
        {
            Id = 324, SaleCode = "poster 501", PageIds = new List<int> {25}, SortIndex = 23, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 501, Name = "Jolly Roger",
            Description = "For pirates everywhere"
        },
        new()
        {
            Id = 325, SaleCode = "club_sofa", PageIds = new List<int> {27}, SortIndex = 1, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 112, SpecialSpriteId = 0, Name = "Club sofa", Description = "Club sofa"
        },
        new()
        {
            Id = 326, SaleCode = "mocchamaster", PageIds = new List<int> {27}, SortIndex = 2, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 123, SpecialSpriteId = 0, Name = "Mochamaster",
            Description = "Wake up and smell it!"
        },
        new()
        {
            Id = 327, SaleCode = "edicehc", PageIds = new List<int> {27}, SortIndex = 3, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 127, SpecialSpriteId = 0, Name = "Dicemaster", Description = "Click and roll!"
        },
        new()
        {
            Id = 328, SaleCode = "hcamme", PageIds = new List<int> {27}, SortIndex = 4, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 129, SpecialSpriteId = 0, Name = "Tubmaster", Description = "Time for a soak"
        },
        new()
        {
            Id = 329, SaleCode = "doorD", PageIds = new List<int> {27}, SortIndex = 5, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 132, SpecialSpriteId = 0, Name = "Imperial Teleport",
            Description = "Let's go over tzar!"
        },
        new()
        {
            Id = 330, SaleCode = "hcsohva", PageIds = new List<int> {27}, SortIndex = 6, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 128, SpecialSpriteId = 0, Name = "Throne Sofa",
            Description = "For royal bottoms..."
        },
        new()
        {
            Id = 331, SaleCode = "hc_lmp", PageIds = new List<int> {27}, SortIndex = 7, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 150, SpecialSpriteId = 0, Name = "Oil Lamp", Description = "Be enlightened"
        },
        new()
        {
            Id = 332, SaleCode = "hc_tbl", PageIds = new List<int> {27}, SortIndex = 8, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 151, SpecialSpriteId = 0, Name = "Nordic Table",
            Description = "Perfect for banquets"
        },
        new()
        {
            Id = 333, SaleCode = "hc_chr", PageIds = new List<int> {27}, SortIndex = 9, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 152, SpecialSpriteId = 0, Name = "Majestic Chair", Description = "Royal comfort"
        },
        new()
        {
            Id = 334, SaleCode = "hc_dsk", PageIds = new List<int> {27}, SortIndex = 10, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 153, SpecialSpriteId = 0, Name = "Study Desk", Description = "For Habbo scholars"
        },
        new()
        {
            Id = 335, SaleCode = "hc_trll", PageIds = new List<int> {27}, SortIndex = 11, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 228, SpecialSpriteId = 0, Name = "Drinks Trolley",
            Description = "For swanky dinners only"
        },
        new()
        {
            Id = 336, SaleCode = "hc_lmpst", PageIds = new List<int> {27}, SortIndex = 12, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 224, SpecialSpriteId = 0, Name = "Victorian Street Light",
            Description = "Somber and atmospheric"
        },
        new()
        {
            Id = 337, SaleCode = "hc_crtn", PageIds = new List<int> {27}, SortIndex = 13, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 221, SpecialSpriteId = 0, Name = "Antique Drapery",
            Description = "Topnotch privacy protection"
        },
        new()
        {
            Id = 338, SaleCode = "hc_tv", PageIds = new List<int> {27}, SortIndex = 14, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 214, SpecialSpriteId = 0, Name = "Mega TV Set",
            Description = "Forget plasma, go HC!"
        },
        new()
        {
            Id = 339, SaleCode = "hc_btlr", PageIds = new List<int> {27}, SortIndex = 15, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 220, SpecialSpriteId = 0, Name = "Electric Butler",
            Description = "Your personal caretaker"
        },
        new()
        {
            Id = 340, SaleCode = "hc_bkshlf", PageIds = new List<int> {27}, SortIndex = 16, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 219, SpecialSpriteId = 0, Name = "Medieval Bookcase",
            Description = "For the scholarly ones"
        },
        new()
        {
            Id = 341, SaleCode = "hc_rntgn", PageIds = new List<int> {27}, SortIndex = 17, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 227, SpecialSpriteId = 0, Name = "X-Ray Divider",
            Description = "Believe it or not!"
        },
        new()
        {
            Id = 342, SaleCode = "hc_frplc", PageIds = new List<int> {27}, SortIndex = 18, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 223, SpecialSpriteId = 0, Name = "Heavy Duty Fireplace",
            Description = "Pixel-powered for maximum heating"
        },
        new()
        {
            Id = 343, SaleCode = "hc_djset", PageIds = new List<int> {27}, SortIndex = 19, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 222, SpecialSpriteId = 0, Name = "The Grammophon",
            Description = "Very old skool scratch'n'spin"
        },
        new()
        {
            Id = 344, SaleCode = "hc_wall_lamp", PageIds = new List<int> {27}, SortIndex = 20, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 246, SpecialSpriteId = 0, Name = "Retro Wall Lamp",
            Description = "Tres chic!"
        },
        new()
        {
            Id = 345, SaleCode = "hc_machine", PageIds = new List<int> {27}, SortIndex = 21, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 225, SpecialSpriteId = 0, Name = "Weird Science Machine",
            Description = "By and for mad inventors"
        },
        new()
        {
            Id = 346, SaleCode = "deal_hcrollers", PageIds = new List<int> {27}, SortIndex = 22, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 0, SpecialSpriteId = 0, Name = "", Description = "",
            IsPackage = true, PackageName = "HC rollers set",
            PackageDescription = "Five of those uber rollers in one pack!"
        },
        new()
        {
            Id = 347, SaleCode = "deal_throne", PageIds = new List<int> {27}, SortIndex = 23, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 0, SpecialSpriteId = 0, Name = "", Description = "",
            IsPackage = true, PackageName = "Throne", PackageDescription = "Ten for the price of one!"
        },
        new()
        {
            Id = 348, SaleCode = "rare_dragonlamp*4", PageIds = new List<int> {28}, SortIndex = 1, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 170, SpecialSpriteId = 0, Name = "Black Dragon Lamp",
            Description = "Scary and scorching!"
        },
        new()
        {
            Id = 349, SaleCode = "rare_dragonlamp*0", PageIds = new List<int> {28}, SortIndex = 2, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 171, SpecialSpriteId = 0, Name = "Fire Dragon Lamp",
            Description = "George and the..."
        },
        new()
        {
            Id = 351, SaleCode = "rare_dragonlamp*2", PageIds = new List<int> {28}, SortIndex = 4, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 173, SpecialSpriteId = 0, Name = "Jade Dragon Lamp",
            Description = "Oriental beast of legends"
        },
        new()
        {
            Id = 352, SaleCode = "rare_dragonlamp*8", PageIds = new List<int> {28}, SortIndex = 5, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 174, SpecialSpriteId = 0, Name = "Bronze Dragon Lamp",
            Description = "Scary and scorching!"
        },
        new()
        {
            Id = 353, SaleCode = "rare_dragonlamp*9", PageIds = new List<int> {28}, SortIndex = 6, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 175, SpecialSpriteId = 0, Name = "Purple Dragon Lamp",
            Description = "Scary and scorching!"
        },
        new()
        {
            Id = 354, SaleCode = "rare_dragonlamp*7", PageIds = new List<int> {28}, SortIndex = 7, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 176, SpecialSpriteId = 0, Name = "Sky Dragon Lamp",
            Description = "Scary and scorching!"
        },
        new()
        {
            Id = 355, SaleCode = "rare_dragonlamp*6", PageIds = new List<int> {28}, SortIndex = 8, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 177, SpecialSpriteId = 0, Name = "Gold Dragon Lamp",
            Description = "Scary and scorching!"
        },
        new()
        {
            Id = 356, SaleCode = "rare_dragonlamp*1", PageIds = new List<int> {28}, SortIndex = 9, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 178, SpecialSpriteId = 0, Name = "Sea Dragon Lamp",
            Description = "Out of the deep blue!"
        },
        new()
        {
            Id = 357, SaleCode = "rare_dragonlamp*3", PageIds = new List<int> {28}, SortIndex = 10, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 179, SpecialSpriteId = 0, Name = "Silver Dragon Lamp",
            Description = "Scary and scorching!"
        },
        new()
        {
            Id = 358, SaleCode = "scifidoor*1", PageIds = new List<int> {29}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 270, SpecialSpriteId = 0, Name = "Pink Spaceship Door",
            Description = "There out of this world!"
        },
        new()
        {
            Id = 359, SaleCode = "scifidoor*10", PageIds = new List<int> {29}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 261, SpecialSpriteId = 0, Name = "Violet Spaceship Door",
            Description = "There out of this world!"
        },
        new()
        {
            Id = 360, SaleCode = "scifidoor*2", PageIds = new List<int> {29}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 269, SpecialSpriteId = 0, Name = "Yellow Spaceship Door",
            Description = "There out of this world!"
        },
        new()
        {
            Id = 361, SaleCode = "scifidoor*3", PageIds = new List<int> {29}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 268, SpecialSpriteId = 0, Name = "Lightblue Spaceship Door",
            Description = "There out of this world!"
        },
        new()
        {
            Id = 362, SaleCode = "scifidoor*4", PageIds = new List<int> {29}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 267, SpecialSpriteId = 0, Name = "Emerald Spaceship Door",
            Description = "Protect your pot of gold!"
        },
        new()
        {
            Id = 363, SaleCode = "scifidoor*5", PageIds = new List<int> {29}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 266, SpecialSpriteId = 0, Name = "White Spaceship Door",
            Description = "There out of this world!"
        },
        new()
        {
            Id = 364, SaleCode = "scifidoor*6", PageIds = new List<int> {29}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 265, SpecialSpriteId = 0, Name = "Black Monolith",
            Description = "Monolith goes up! Monolith goes down!"
        },
        new()
        {
            Id = 365, SaleCode = "scifidoor*7", PageIds = new List<int> {29}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 264, SpecialSpriteId = 0, Name = "Aqua Spaceship Door",
            Description = "There out of this world!"
        },
        new()
        {
            Id = 366, SaleCode = "scifidoor*8", PageIds = new List<int> {29}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 263, SpecialSpriteId = 0, Name = "Purple Spaceship Door",
            Description = "There out of this world!"
        },
        new()
        {
            Id = 367, SaleCode = "scifidoor*9", PageIds = new List<int> {29}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 262, SpecialSpriteId = 0, Name = "Blue Spaceship Door",
            Description = "There out of this world!"
        },
        new()
        {
            Id = 368, SaleCode = "rare_parasol*0", PageIds = new List<int> {30}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 260, SpecialSpriteId = 0, Name = "Green Parasol",
            Description = "Block those rays!"
        },
        new()
        {
            Id = 369, SaleCode = "rare_parasol*1", PageIds = new List<int> {30}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 257, SpecialSpriteId = 0, Name = "Yellow Parasol",
            Description = "Block those rays!"
        },
        new()
        {
            Id = 370, SaleCode = "rare_parasol*2", PageIds = new List<int> {30}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 258, SpecialSpriteId = 0, Name = "Orange Parasol",
            Description = "Block those rays!"
        },
        new()
        {
            Id = 371, SaleCode = "rare_parasol*3", PageIds = new List<int> {30}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 259, SpecialSpriteId = 0, Name = "Violet Parasol",
            Description = "Block those rays!"
        },
        new()
        {
            Id = 372, SaleCode = "wooden_screen*0", PageIds = new List<int> {31}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 317, SpecialSpriteId = 0, Name = "White Oriental Screen",
            Description = "Add an exotic touch to your room"
        },
        new()
        {
            Id = 373, SaleCode = "wooden_screen*1", PageIds = new List<int> {31}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 314, SpecialSpriteId = 0, Name = "Pink Oriental screen",
            Description = "Add an exotic touch to your room"
        },
        new()
        {
            Id = 374, SaleCode = "wooden_screen*2", PageIds = new List<int> {31}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 315, SpecialSpriteId = 0, Name = "RosewoodScreen",
            Description = "Add an exotic touch to your room"
        },
        new()
        {
            Id = 375, SaleCode = "wooden_screen*3", PageIds = new List<int> {31}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 323, SpecialSpriteId = 0, Name = "Aqua Oriental Screen",
            Description = "Add an exotic touch to your room"
        },
        new()
        {
            Id = 376, SaleCode = "wooden_screen*4", PageIds = new List<int> {31}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 321, SpecialSpriteId = 0, Name = "Golden Oriental Screen",
            Description = "Add an exotic touch to your room"
        },
        new()
        {
            Id = 377, SaleCode = "wooden_screen*5", PageIds = new List<int> {31}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 319, SpecialSpriteId = 0, Name = "Gray Oriental Screen",
            Description = "Add an exotic touch to your room"
        },
        new()
        {
            Id = 378, SaleCode = "wooden_screen*6", PageIds = new List<int> {31}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 322, SpecialSpriteId = 0, Name = "Blue Oriental Screen",
            Description = "Add an exotic touch to your room"
        },
        new()
        {
            Id = 379, SaleCode = "wooden_screen*7", PageIds = new List<int> {31}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 316, SpecialSpriteId = 0, Name = "Purple Oriental Screen",
            Description = "Add an exotic touch to your room"
        },
        new()
        {
            Id = 380, SaleCode = "wooden_screen*8", PageIds = new List<int> {31}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 318, SpecialSpriteId = 0, Name = "Night Blue Oriental Screen",
            Description = "Add an exotic touch to your room"
        },
        new()
        {
            Id = 381, SaleCode = "wooden_screen*9", PageIds = new List<int> {31}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 320, SpecialSpriteId = 0, Name = "Green Oriental Screen",
            Description = "Add an exotic touch to your room"
        },
        new()
        {
            Id = 382, SaleCode = "marquee*1", PageIds = new List<int> {32}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 304, SpecialSpriteId = 0, Name = "Pink marquee",
            Description = "It's both door and a shade!"
        },
        new()
        {
            Id = 383, SaleCode = "marquee*2", PageIds = new List<int> {32}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 305, SpecialSpriteId = 0, Name = "Red Dragon Marquee",
            Description = "Dragons out and Davids in!"
        },
        new()
        {
            Id = 384, SaleCode = "marquee*3", PageIds = new List<int> {32}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 313, SpecialSpriteId = 0, Name = "Aqua Marquee",
            Description = "It's both door and a shade!"
        },
        new()
        {
            Id = 385, SaleCode = "marquee*4", PageIds = new List<int> {32}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 311, SpecialSpriteId = 0, Name = "Yellow Marquee",
            Description = "It's both door and a shade!"
        },
        new()
        {
            Id = 386, SaleCode = "marquee*5", PageIds = new List<int> {32}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 310, SpecialSpriteId = 0, Name = "Graphite Marquee",
            Description = "It's both door and a shade!"
        },
        new()
        {
            Id = 387, SaleCode = "marquee*6", PageIds = new List<int> {32}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 312, SpecialSpriteId = 0, Name = "Blue Marquee",
            Description = "It's both door and a shade!"
        },
        new()
        {
            Id = 388, SaleCode = "marquee*7", PageIds = new List<int> {32}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 306, SpecialSpriteId = 0, Name = "Purple Marquee",
            Description = "It's both door and a shade!"
        },
        new()
        {
            Id = 389, SaleCode = "marquee*8", PageIds = new List<int> {32}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 308, SpecialSpriteId = 0, Name = "Ultramarine Marquee",
            Description = "It's both door and a shade!"
        },
        new()
        {
            Id = 390, SaleCode = "marquee*9", PageIds = new List<int> {32}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 309, SpecialSpriteId = 0, Name = "Green Marquee",
            Description = "It's both door and a shade!"
        },
        new()
        {
            Id = 392, SaleCode = "pillow*5", PageIds = new List<int> {33}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 294, SpecialSpriteId = 0, Name = "Black Leather Pillow",
            Description = "Puffy, soft and huge"
        },
        new()
        {
            Id = 393, SaleCode = "pillow*8", PageIds = new List<int> {33}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 295, SpecialSpriteId = 0, Name = "Navy Cord Pillow",
            Description = "Puffy, soft and huge"
        },
        new()
        {
            Id = 394, SaleCode = "pillow*0", PageIds = new List<int> {33}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 296, SpecialSpriteId = 0, Name = "White Lace Pillow",
            Description = "Minimalist comfort!"
        },
        new()
        {
            Id = 395, SaleCode = "pillow*1", PageIds = new List<int> {33}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 297, SpecialSpriteId = 0, Name = "Pink Fluffy Pillow",
            Description = "Puffy, soft and huge"
        },
        new()
        {
            Id = 396, SaleCode = "pillow*2", PageIds = new List<int> {33}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 298, SpecialSpriteId = 0, Name = "Red Silk Pillow",
            Description = "Puffy, soft and huge"
        },
        new()
        {
            Id = 397, SaleCode = "pillow*7", PageIds = new List<int> {33}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 299, SpecialSpriteId = 0, Name = "Purple Velvet Pillow",
            Description = "Bonnie's pillow of choice!"
        },
        new()
        {
            Id = 398, SaleCode = "pillow*9", PageIds = new List<int> {33}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 300, SpecialSpriteId = 0, Name = "Green Wooly Pillow",
            Description = "Puffy, soft and VERY fluffy!"
        },
        new()
        {
            Id = 399, SaleCode = "pillow*4", PageIds = new List<int> {33}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 301, SpecialSpriteId = 0, Name = "Gold Feather Pillow",
            Description = "Puffy, soft and huge"
        },
        new()
        {
            Id = 400, SaleCode = "pillow*6", PageIds = new List<int> {33}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 302, SpecialSpriteId = 0, Name = "Blue Cotton Pillow",
            Description = "Puffy, soft and huge"
        },
        new()
        {
            Id = 401, SaleCode = "pillow*3", PageIds = new List<int> {33}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 303, SpecialSpriteId = 0, Name = "Turquoise Satin Pillow",
            Description = "Puffy, soft and huge"
        },
        new()
        {
            Id = 402, SaleCode = "rare_icecream*0", PageIds = new List<int> {34}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 331, SpecialSpriteId = 0, Name = "Cherry Ice Cream Machine",
            Description = "Virtual cherry rocks!"
        },
        new()
        {
            Id = 403, SaleCode = "rare_icecream*1", PageIds = new List<int> {34}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 324, SpecialSpriteId = 0, Name = "Blueberry Ice Cream Machine",
            Description = "Virtual blueberry rocks!"
        },
        new()
        {
            Id = 404, SaleCode = "rare_icecream*2", PageIds = new List<int> {34}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 327, SpecialSpriteId = 0, Name = "Pistachio Ice Cream Machine",
            Description = "Virtual pistachio rocks!"
        },
        new()
        {
            Id = 405, SaleCode = "rare_icecream*3", PageIds = new List<int> {34}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 330, SpecialSpriteId = 0,
            Name = "Blackcurrant Ice Cream Machine", Description = "Virtual blackcurrant rocks!"
        },
        new()
        {
            Id = 406, SaleCode = "rare_icecream*4", PageIds = new List<int> {34}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 332, SpecialSpriteId = 0,
            Name = "Strawberry Ice Cream Machine", Description = "Virtual strawberry rocks!"
        },
        new()
        {
            Id = 407, SaleCode = "rare_icecream*5", PageIds = new List<int> {34}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 333, SpecialSpriteId = 0, Name = "Vanilla Ice Cream Machine",
            Description = "Virtual vanilla rocks!"
        },
        new()
        {
            Id = 408, SaleCode = "rare_icecream*6", PageIds = new List<int> {34}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 328, SpecialSpriteId = 0, Name = "Toffee Ice Cream Machine",
            Description = "Virtual toffee rocks!"
        },
        new()
        {
            Id = 409, SaleCode = "rare_icecream*7", PageIds = new List<int> {34}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 325, SpecialSpriteId = 0, Name = "Chocolate Ice Cream Machine",
            Description = "Virtual chocolate rocks!"
        },
        new()
        {
            Id = 410, SaleCode = "rare_icecream*8", PageIds = new List<int> {34}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 326, SpecialSpriteId = 0,
            Name = "Peppermint Ice Cream Machine", Description = "Virtual peppermint rocks!"
        },
        new()
        {
            Id = 411, SaleCode = "rare_icecream*9", PageIds = new List<int> {34}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 329, SpecialSpriteId = 0, Name = "Bubblegum Ice Cream Machine",
            Description = "Virtual bubblegum rocks!"
        },
        new()
        {
            Id = 412, SaleCode = "scifirocket*0", PageIds = new List<int> {35}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 293, SpecialSpriteId = 0, Name = "Mars Smoke Machine",
            Description = "See in 2007 with a bang!"
        },
        new()
        {
            Id = 413, SaleCode = "scifirocket*1", PageIds = new List<int> {35}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 292, SpecialSpriteId = 0, Name = "Saturn Smoke Machine",
            Description = "There is always space for this!"
        },
        new()
        {
            Id = 414, SaleCode = "scifirocket*2", PageIds = new List<int> {35}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 291, SpecialSpriteId = 0, Name = "Earth Smoke Machine",
            Description = "A little closer to home!"
        },
        new()
        {
            Id = 415, SaleCode = "scifirocket*3", PageIds = new List<int> {35}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 290, SpecialSpriteId = 0, Name = "Endor Smoke Machine",
            Description = "Caution! Unknown Location!"
        },
        new()
        {
            Id = 416, SaleCode = "scifirocket*4", PageIds = new List<int> {35}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 289, SpecialSpriteId = 0, Name = "Venus Smoke Machine",
            Description = "Welcome... to planet love"
        },
        new()
        {
            Id = 417, SaleCode = "scifirocket*5", PageIds = new List<int> {35}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 288, SpecialSpriteId = 0, Name = "Uranus Smoke Machine",
            Description = "From the unknown depths of space"
        },
        new()
        {
            Id = 418, SaleCode = "scifirocket*6", PageIds = new List<int> {35}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 287, SpecialSpriteId = 0, Name = "Mercury Smoke Machine",
            Description = "Too hot to handle!"
        },
        new()
        {
            Id = 419, SaleCode = "scifirocket*7", PageIds = new List<int> {35}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 286, SpecialSpriteId = 0, Name = "Jupiter Smoke Machine",
            Description = "Larger than life!"
        },
        new()
        {
            Id = 420, SaleCode = "scifirocket*8", PageIds = new List<int> {35}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 285, SpecialSpriteId = 0, Name = "Pluto Smoke Machine",
            Description = "From a space far, far away!"
        },
        new()
        {
            Id = 421, SaleCode = "scifirocket*9", PageIds = new List<int> {35}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 284, SpecialSpriteId = 0, Name = "Neptune Smoke Machine",
            Description = "Something fishy is going on..."
        },
        new()
        {
            Id = 422, SaleCode = "scifiport*0", PageIds = new List<int> {36}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 274, SpecialSpriteId = 0, Name = "Red Laser Door",
            Description = "Energy beams. No trespassers!"
        },
        new()
        {
            Id = 423, SaleCode = "scifiport*1", PageIds = new List<int> {36}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 283, SpecialSpriteId = 0, Name = "Gold Laser Gate",
            Description = "Energy beams. No trespassers!"
        },
        new()
        {
            Id = 424, SaleCode = "scifiport*2", PageIds = new List<int> {36}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 282, SpecialSpriteId = 0, Name = "Blue Laser Gate",
            Description = "Get in the ring!"
        },
        new()
        {
            Id = 425, SaleCode = "scifiport*3", PageIds = new List<int> {36}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 281, SpecialSpriteId = 0, Name = "Jade Sci-Fi Port",
            Description = "Energy beams. No trespassers!"
        },
        new()
        {
            Id = 426, SaleCode = "scifiport*4", PageIds = new List<int> {36}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 280, SpecialSpriteId = 0, Name = "Pink Sci-Fi Port",
            Description = "Energy beams. No trespassers!"
        },
        new()
        {
            Id = 427, SaleCode = "scifiport*5", PageIds = new List<int> {36}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 279, SpecialSpriteId = 0, Name = "Security Fence",
            Description = "Recovered from Roswell"
        },
        new()
        {
            Id = 428, SaleCode = "scifiport*6", PageIds = new List<int> {36}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 278, SpecialSpriteId = 0, Name = "White Sci-Fi Port",
            Description = "Energy beams. No trespassers!"
        },
        new()
        {
            Id = 429, SaleCode = "scifiport*7", PageIds = new List<int> {36}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 277, SpecialSpriteId = 0, Name = "Turquoise Sci-Fi Port",
            Description = "Energy beams. No trespassers!"
        },
        new()
        {
            Id = 430, SaleCode = "scifiport*8", PageIds = new List<int> {36}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 276, SpecialSpriteId = 0, Name = "Purple Sci-Fi Port",
            Description = "Energy beams. No trespassers!"
        },
        new()
        {
            Id = 431, SaleCode = "scifiport*9", PageIds = new List<int> {36}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 275, SpecialSpriteId = 0, Name = "Violet Sci-Fi Port",
            Description = "Energy beams. No trespassers!"
        },
        new()
        {
            Id = 432, SaleCode = "rare_beehive_bulb", PageIds = new List<int> {37}, SortIndex = 53, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 271, SpecialSpriteId = 0, Name = "Blue Amber Lamp",
            Description = "A honey-hued glow"
        },
        new()
        {
            Id = 433, SaleCode = "rare_beehive_bulb*1", PageIds = new List<int> {37}, SortIndex = 53, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 272, SpecialSpriteId = 0, Name = "Red Amber Lamp",
            Description = "A honey-hued glow"
        },
        new()
        {
            Id = 434, SaleCode = "rare_beehive_bulb*2", PageIds = new List<int> {37}, SortIndex = 53, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 273, SpecialSpriteId = 0, Name = "Yellow Amber Lamp",
            Description = "A honey-hued glow"
        },
        new()
        {
            Id = 435, SaleCode = "rare_fountain", PageIds = new List<int> {38}, SortIndex = 54, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 334, SpecialSpriteId = 0, Name = "Bird Bath (red)",
            Description = "For our feathered friends"
        },
        new()
        {
            Id = 436, SaleCode = "rare_fountain*1", PageIds = new List<int> {38}, SortIndex = 54, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 335, SpecialSpriteId = 0, Name = "Bird Bath (grey)",
            Description = "For our feathered friends"
        },
        new()
        {
            Id = 437, SaleCode = "rare_fountain*2", PageIds = new List<int> {38}, SortIndex = 54, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 336, SpecialSpriteId = 0, Name = "Bird Bath (green)",
            Description = "For our feathered friends"
        },
        new()
        {
            Id = 438, SaleCode = "rare_fountain*3", PageIds = new List<int> {38}, SortIndex = 54, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 337, SpecialSpriteId = 0, Name = "Bird Bath (blue)",
            Description = "For our feathered friends"
        },
        new()
        {
            Id = 439, SaleCode = "rare_elephant_statue", PageIds = new List<int> {39}, SortIndex = 55, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 338, SpecialSpriteId = 0, Name = "Golden Elephant",
            Description = "Say hello to Nelly"
        },
        new()
        {
            Id = 440, SaleCode = "rare_elephant_statue*1", PageIds = new List<int> {39}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 339, SpecialSpriteId = 0, Name = "Silver Elephant",
            Description = "Say hello to Nelly"
        },
        new()
        {
            Id = 441, SaleCode = "rare_elephant_statue*2", PageIds = new List<int> {39}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 340, SpecialSpriteId = 0, Name = "Bronze Elephant",
            Description = "Say hello to Nelly"
        },
        new()
        {
            Id = 442, SaleCode = "rare_fan*0", PageIds = new List<int> {40}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 345, SpecialSpriteId = 0, Name = "Festive Fan",
            Description = "As red as Rudolph's nose"
        },
        new()
        {
            Id = 443, SaleCode = "rare_fan*1", PageIds = new List<int> {40}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 348, SpecialSpriteId = 0, Name = "Birthday Fan",
            Description = "It'll blow your candles out!"
        },
        new()
        {
            Id = 444, SaleCode = "rare_fan*2", PageIds = new List<int> {40}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 350, SpecialSpriteId = 0, Name = "Green Powered Fan",
            Description = "It'll blow you away!"
        },
        new()
        {
            Id = 445, SaleCode = "rare_fan*3", PageIds = new List<int> {40}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 344, SpecialSpriteId = 0, Name = "Purple Dragon Skin Fan",
            Description = "Keeps the heat off St George!"
        },
        new()
        {
            Id = 446, SaleCode = "rare_fan*4", PageIds = new List<int> {40}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 346, SpecialSpriteId = 0, Name = "SUPERLOVE Fan",
            Description = "Fanning the fires of SUPERLOVE..."
        },
        new()
        {
            Id = 447, SaleCode = "rare_fan*5", PageIds = new List<int> {40}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 347, SpecialSpriteId = 0, Name = "Yellow Powered Fan",
            Description = "It'll blow you away!"
        },
        new()
        {
            Id = 448, SaleCode = "rare_fan*6", PageIds = new List<int> {40}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 342, SpecialSpriteId = 0, Name = "Ochre Powered Fan",
            Description = "It'll blow you away!"
        },
        new()
        {
            Id = 449, SaleCode = "rare_fan*7", PageIds = new List<int> {40}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 341, SpecialSpriteId = 0, Name = "Brown Powered Fan",
            Description = "...it's really hit the fan!"
        },
        new()
        {
            Id = 450, SaleCode = "rare_fan*8", PageIds = new List<int> {40}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 349, SpecialSpriteId = 0, Name = "Habbo Wind Turbine",
            Description = "Stylish, Eco-Energy!"
        },
        new()
        {
            Id = 451, SaleCode = "rare_fan*9", PageIds = new List<int> {40}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 343, SpecialSpriteId = 0, Name = "Fucsia Powered Fan",
            Description = "It'll blow you away!"
        },
        new()
        {
            Id = 452, SaleCode = "habbowheel", PageIds = new List<int> {19}, SortIndex = 0, Price = 8, IsHidden = false,
            Amount = 1, DefinitionId = 351, SpecialSpriteId = 0, Name = "The Wheel of Destiny!",
            Description = "So you gotta ask yourself, 'Do I feel lucky?'"
        },
        new()
        {
            Id = 453, SaleCode = "roomdimmer", PageIds = new List<int> {19}, SortIndex = 0, Price = 12, IsHidden = true,
            Amount = 1, DefinitionId = 352, SpecialSpriteId = 0, Name = "Mood Light",
            Description = "Superior lighting for your room"
        },
        new()
        {
            Id = 454, SaleCode = "jukebox*1", PageIds = new List<int> {11, 84, 85, 86, 87, 88, 89}, SortIndex = 2,
            Price = 3, IsHidden = false, Amount = 1, DefinitionId = 353, SpecialSpriteId = 0, Name = "Jukebox",
            Description = "For your Happy Days!"
        },
        new()
        {
            Id = 455, SaleCode = "jukebox_ptv*1", PageIds = new List<int> {11}, SortIndex = 0, Price = 8,
            IsHidden = true, Amount = 1, DefinitionId = 354, SpecialSpriteId = 0, Name = "Jukebox Pacha TV",
            Description = "Jukebox Pacha TV"
        },
        new()
        {
            Id = 456, SaleCode = "carpet_soft_tut", PageIds = new List<int> {23}, SortIndex = 0, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 355, SpecialSpriteId = 0, Name = "Welcome Mat",
            Description = "Welcome, enjoy your stay!"
        },
        new()
        {
            Id = 458, SaleCode = "sound_set_10", PageIds = new List<int> {89}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 357, SpecialSpriteId = 0, Name = "Hip Hop Beats 1",
            Description = "Made from real Boy Bands!"
        },
        new()
        {
            Id = 459, SaleCode = "sound_set_11", PageIds = new List<int> {86}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 361, SpecialSpriteId = 0, Name = "Dance 4",
            Description = "Music you can really sink your teeth into"
        },
        new()
        {
            Id = 460, SaleCode = "sound_set_12", PageIds = new List<int> {88}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 362, SpecialSpriteId = 0, Name = "Habbo Sounds 2",
            Description = "Unusual as Standard"
        },
        new()
        {
            Id = 461, SaleCode = "sound_set_13", PageIds = new List<int> {86}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 363, SpecialSpriteId = 0, Name = "Dance 5",
            Description = "Let Music be the food of Habbo"
        },
        new()
        {
            Id = 462, SaleCode = "sound_set_14", PageIds = new List<int> {89}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 364, SpecialSpriteId = 0, Name = "Hip Hop Beats 2",
            Description = "Rock them bodies"
        },
        new()
        {
            Id = 463, SaleCode = "sound_set_15", PageIds = new List<int> {89}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 365, SpecialSpriteId = 0, Name = "RnB Grooves 6",
            Description = "Unadulterated essentials"
        },
        new()
        {
            Id = 464, SaleCode = "sound_set_16", PageIds = new List<int> {89}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 366, SpecialSpriteId = 0, Name = "Hip Hop Beats 3",
            Description = "Ferry, ferry good!"
        },
        new()
        {
            Id = 465, SaleCode = "sound_set_17", PageIds = new List<int> {85}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 367, SpecialSpriteId = 0, Name = "Groove 3",
            Description = "Jive's Alive!"
        },
        new()
        {
            Id = 466, SaleCode = "sound_set_18", PageIds = new List<int> {85}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 368, SpecialSpriteId = 0, Name = "Groove 4",
            Description = "Listen while you tan"
        },
        new()
        {
            Id = 467, SaleCode = "sound_set_19", PageIds = new List<int> {89}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 369, SpecialSpriteId = 0, Name = "Hip Hop Beats 4",
            Description = "Shake your body!"
        },
        new()
        {
            Id = 468, SaleCode = "sound_set_20", PageIds = new List<int> {88}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 370, SpecialSpriteId = 0, Name = "SFX 2",
            Description = "Musical heaven"
        },
        new()
        {
            Id = 469, SaleCode = "sound_set_21", PageIds = new List<int> {87}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 371, SpecialSpriteId = 0, Name = "Rock 1",
            Description = "Headbanging riffs"
        },
        new()
        {
            Id = 470, SaleCode = "sound_set_22", PageIds = new List<int> {88}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 372, SpecialSpriteId = 0, Name = "SFX 3",
            Description = "With a hamper full of sounds, not sarnies"
        },
        new()
        {
            Id = 471, SaleCode = "sound_set_23", PageIds = new List<int> {88}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 373, SpecialSpriteId = 0, Name = "SFX 4",
            Description = "Don't be afraid of the dark"
        },
        new()
        {
            Id = 472, SaleCode = "sound_set_24", PageIds = new List<int> {88}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 374, SpecialSpriteId = 0, Name = "Habbo Sounds 4",
            Description = "It's all about the Pentiums, baby!"
        },
        new()
        {
            Id = 473, SaleCode = "sound_set_25", PageIds = new List<int> {86}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 375, SpecialSpriteId = 0, Name = "Dance 1",
            Description = "Actually, it's Partay!"
        },
        new()
        {
            Id = 474, SaleCode = "sound_set_26", PageIds = new List<int> {85}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 376, SpecialSpriteId = 0, Name = "Groove 1",
            Description = "Bollywood Beats!"
        },
        new()
        {
            Id = 475, SaleCode = "sound_set_27", PageIds = new List<int> {85}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 377, SpecialSpriteId = 0, Name = "Groove 2",
            Description = "Jingle Bells will never be the same..."
        },
        new()
        {
            Id = 476, SaleCode = "sound_set_28", PageIds = new List<int> {87}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 378, SpecialSpriteId = 0, Name = "Rock 2",
            Description = "Head for the pit!"
        },
        new()
        {
            Id = 477, SaleCode = "sound_set_29", PageIds = new List<int> {86}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 379, SpecialSpriteId = 0, Name = "Dance 2",
            Description = "Electronic house"
        },
        new()
        {
            Id = 478, SaleCode = "sound_set_30", PageIds = new List<int> {88}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 380, SpecialSpriteId = 0, Name = "Instrumental 1",
            Description = "Moments in love"
        },
        new()
        {
            Id = 479, SaleCode = "sound_set_31", PageIds = new List<int> {86}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 381, SpecialSpriteId = 0, Name = "Dance 3",
            Description = "House loops"
        },
        new()
        {
            Id = 480, SaleCode = "sound_set_32", PageIds = new List<int> {88}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 382, SpecialSpriteId = 0, Name = "Instrumental 2",
            Description = "Piano concert set"
        },
        new()
        {
            Id = 481, SaleCode = "sound_set_33", PageIds = new List<int> {87}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 383, SpecialSpriteId = 0, Name = "Rock 3",
            Description = "Guitar solo set"
        },
        new()
        {
            Id = 482, SaleCode = "sound_set_34", PageIds = new List<int> {87}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 384, SpecialSpriteId = 0, Name = "Rock 5",
            Description = "For guitar heroes"
        },
        new()
        {
            Id = 483, SaleCode = "sound_set_35", PageIds = new List<int> {85}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 385, SpecialSpriteId = 0, Name = "Dance 6",
            Description = "Groovelicious"
        },
        new()
        {
            Id = 484, SaleCode = "sound_set_36", PageIds = new List<int> {89}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 386, SpecialSpriteId = 0, Name = "Latin Love 1",
            Description = "For adult minded"
        },
        new()
        {
            Id = 485, SaleCode = "sound_set_37", PageIds = new List<int> {88}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 387, SpecialSpriteId = 0, Name = "Habbowood Traxpack",
            Description = "Blockbuster hits!"
        },
        new()
        {
            Id = 486, SaleCode = "sound_set_38", PageIds = new List<int> {87}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 388, SpecialSpriteId = 0, Name = "Rock 6",
            Description = "Rock and Roses!"
        },
        new()
        {
            Id = 487, SaleCode = "sound_set_39", PageIds = new List<int> {87}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 389, SpecialSpriteId = 0, Name = "Rock 7",
            Description = "Rock with a roll"
        },
        new()
        {
            Id = 488, SaleCode = "sound_set_40", PageIds = new List<int> {87}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 390, SpecialSpriteId = 0, Name = "Rock 4",
            Description = "Dude? Cheese!"
        },
        new()
        {
            Id = 489, SaleCode = "sound_set_41", PageIds = new List<int> {87}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 391, SpecialSpriteId = 0, Name = "Rock 8",
            Description = "Burning Riffs"
        },
        new()
        {
            Id = 490, SaleCode = "sound_set_42", PageIds = new List<int> {85}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 392, SpecialSpriteId = 0, Name = "Haunted Mansion",
            Description = "Bumps and Chills"
        },
        new()
        {
            Id = 491, SaleCode = "sound_set_43", PageIds = new List<int> {88}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 393, SpecialSpriteId = 0, Name = "SFX 1",
            Description = "Beware zombies!"
        },
        new()
        {
            Id = 492, SaleCode = "sound_set_44", PageIds = new List<int> {85}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 394, SpecialSpriteId = 0, Name = "Graveyard Portal",
            Description = "Haunted Dimension"
        },
        new()
        {
            Id = 493, SaleCode = "sound_set_45", PageIds = new List<int> {89}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 395, SpecialSpriteId = 0, Name = "Lost_Beatness",
            Description = "The Bass? is the rhythm!"
        },
        new()
        {
            Id = 494, SaleCode = "sound_set_46", PageIds = new List<int> {86}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 396, SpecialSpriteId = 0, Name = "Club 1",
            Description = "De bada bada bo!"
        },
        new()
        {
            Id = 495, SaleCode = "sound_set_47", PageIds = new List<int> {86}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 397, SpecialSpriteId = 0, Name = "Club 2",
            Description = "Storm the UKCharts!"
        },
        new()
        {
            Id = 496, SaleCode = "sound_set_48", PageIds = new List<int> {86}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 398, SpecialSpriteId = 0, Name = "Club 3",
            Description = "Sweet party beat"
        },
        new()
        {
            Id = 497, SaleCode = "sound_set_49", PageIds = new List<int> {86}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 399, SpecialSpriteId = 0, Name = "Club 4",
            Description = "You will belong"
        },
        new()
        {
            Id = 498, SaleCode = "sound_set_50", PageIds = new List<int> {86}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 400, SpecialSpriteId = 0, Name = "Club 5",
            Description = "The harder generation"
        },
        new()
        {
            Id = 499, SaleCode = "sound_set_51", PageIds = new List<int> {86}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 401, SpecialSpriteId = 0, Name = "Club 6",
            Description = "Bop to the beat"
        },
        new()
        {
            Id = 500, SaleCode = "sound_set_52", PageIds = new List<int> {86}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 402, SpecialSpriteId = 0, Name = "Club 7",
            Description = "State of Trancehouse"
        },
        new()
        {
            Id = 503, SaleCode = "sound_set_55", PageIds = new List<int> {89}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 405, SpecialSpriteId = 0, Name = "RnB Grooves 1",
            Description = "Can you fill me in?"
        },
        new()
        {
            Id = 504, SaleCode = "sound_set_56", PageIds = new List<int> {89}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 406, SpecialSpriteId = 0, Name = "RnB Grooves 2",
            Description = "Get down tonight!"
        },
        new()
        {
            Id = 505, SaleCode = "sound_set_57", PageIds = new List<int> {89}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 407, SpecialSpriteId = 0, Name = "RnB Grooves 3",
            Description = "Feel the groove"
        },
        new()
        {
            Id = 506, SaleCode = "sound_set_58", PageIds = new List<int> {89}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 408, SpecialSpriteId = 0, Name = "RnB Grooves 4",
            Description = "Sh-shake it!"
        },
        new()
        {
            Id = 507, SaleCode = "sound_set_59", PageIds = new List<int> {89}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 409, SpecialSpriteId = 0, Name = "RnB Grooves 5",
            Description = "Urban break beats"
        },
        new()
        {
            Id = 508, SaleCode = "sound_set_60", PageIds = new List<int> {89}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 410, SpecialSpriteId = 0, Name = "Latin Love 2",
            Description = "Love and affection!"
        },
        new()
        {
            Id = 509, SaleCode = "sound_set_61", PageIds = new List<int> {89}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 411, SpecialSpriteId = 0, Name = "Latin Love 3",
            Description = "Straight from the heart"
        },
        new()
        {
            Id = 510, SaleCode = "sound_set_62", PageIds = new List<int> {46}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 412, SpecialSpriteId = 0, Name = "Alhambra Trax 1",
            Description = "Music of the Arabian night!"
        },
        new()
        {
            Id = 511, SaleCode = "sound_set_63", PageIds = new List<int> {46}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 413, SpecialSpriteId = 0, Name = "Alhambra Trax 2",
            Description = "Desert hits by the oasis!"
        },
        new()
        {
            Id = 512, SaleCode = "sound_set_64", PageIds = new List<int> {46}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 414, SpecialSpriteId = 0, Name = "Alhambra Trax 3",
            Description = "Make a little Jinn-gle!"
        },
        new()
        {
            Id = 513, SaleCode = "camera", PageIds = new List<int> {41}, SortIndex = 0, Price = 10, IsHidden = false,
            Amount = 1, DefinitionId = 421, SpecialSpriteId = 0, Name = "Camera", Description = "Smile!"
        },
        new()
        {
            Id = 514, SaleCode = "film", PageIds = new List<int> {41}, SortIndex = 1, Price = 6, IsHidden = false,
            Amount = 1, DefinitionId = 423, SpecialSpriteId = 0, Name = "", Description = ""
        },
        new()
        {
            Id = 515, SaleCode = "chair_plasto*1", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 439, SpecialSpriteId = 0, Name = "Chair",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 516, SaleCode = "chair_plasto", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 467, SpecialSpriteId = 0, Name = "Chair",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 517, SaleCode = "chair_plasto*10", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 651, SpecialSpriteId = 0, Name = "", Description = ""
        },
        new()
        {
            Id = 518, SaleCode = "chair_plasto*11", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 652, SpecialSpriteId = 0, Name = "", Description = ""
        },
        new()
        {
            Id = 519, SaleCode = "chair_plasto*2", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 474, SpecialSpriteId = 0, Name = "Chair",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 520, SaleCode = "chair_plasto*3", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 481, SpecialSpriteId = 0, Name = "Chair",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 521, SaleCode = "chair_plasto*4", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 488, SpecialSpriteId = 0, Name = "Chair",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 522, SaleCode = "chair_plasto*5", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 498, SpecialSpriteId = 0, Name = "Chair",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 523, SaleCode = "chair_plasto*6", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 503, SpecialSpriteId = 0, Name = "Chair",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 524, SaleCode = "chair_plasto*7", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 508, SpecialSpriteId = 0, Name = "Chair",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 525, SaleCode = "chair_plasto*8", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 513, SpecialSpriteId = 0, Name = "Chair",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 526, SaleCode = "chair_plasto*9", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 518, SpecialSpriteId = 0, Name = "Chair",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 527, SaleCode = "chair_plasty", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 438, SpecialSpriteId = 0, Name = "Plastic Pod Chair",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 528, SaleCode = "chair_plasty*1", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 520, SpecialSpriteId = 0, Name = "Plastic Pod Chair",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 529, SaleCode = "chair_plasty*10", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 706, SpecialSpriteId = 0, Name = "Plastic Pod Chair",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 530, SaleCode = "chair_plasty*11", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 707, SpecialSpriteId = 0, Name = "Plastic Pod Chair",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 531, SaleCode = "chair_plasty*2", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 523, SpecialSpriteId = 0, Name = "Plastic Pod Chair",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 532, SaleCode = "chair_plasty*3", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 524, SpecialSpriteId = 0, Name = "Plastic Pod Chair",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 533, SaleCode = "chair_plasty*4", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 525, SpecialSpriteId = 0, Name = "Plastic Pod Chair",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 534, SaleCode = "chair_plasty*5", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 545, SpecialSpriteId = 0, Name = "Plastic Pod Chair",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 535, SaleCode = "chair_plasty*6", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 549, SpecialSpriteId = 0, Name = "Plastic Pod Chair",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 536, SaleCode = "chair_plasty*7", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 703, SpecialSpriteId = 0, Name = "Plastic Pod Chair",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 537, SaleCode = "chair_plasty*8", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 704, SpecialSpriteId = 0, Name = "Plastic Pod Chair",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 538, SaleCode = "chair_plasty*9", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 705, SpecialSpriteId = 0, Name = "Plastic Pod Chair",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 539, SaleCode = "table_plasto_4leg", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 424, SpecialSpriteId = 0, Name = "Occasional Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 540, SaleCode = "table_plasto_4leg*1", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 463, SpecialSpriteId = 0, Name = "Square Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 541, SaleCode = "table_plasto_4leg*10", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 694, SpecialSpriteId = 0, Name = "Occasional Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 542, SaleCode = "table_plasto_4leg*14", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 658, SpecialSpriteId = 0, Name = "HC table",
            Description = "Aqua table"
        },
        new()
        {
            Id = 543, SaleCode = "table_plasto_4leg*2", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 470, SpecialSpriteId = 0, Name = "Occasional Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 544, SaleCode = "table_plasto_4leg*3", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 477, SpecialSpriteId = 0, Name = "Round Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 545, SaleCode = "table_plasto_4leg*4", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 484, SpecialSpriteId = 0, Name = "", Description = ""
        },
        new()
        {
            Id = 546, SaleCode = "table_plasto_4leg*5", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 494, SpecialSpriteId = 0, Name = "Occasional Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 547, SaleCode = "table_plasto_4leg*6", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 499, SpecialSpriteId = 0, Name = "Occasional table Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 548, SaleCode = "table_plasto_4leg*7", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 504, SpecialSpriteId = 0, Name = "Occasional table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 549, SaleCode = "table_plasto_4leg*8", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 509, SpecialSpriteId = 0, Name = "Occasional Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 550, SaleCode = "table_plasto_4leg*9", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 514, SpecialSpriteId = 0, Name = "Occasional Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 551, SaleCode = "table_plasto_bigsquare", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 426, SpecialSpriteId = 0, Name = "Square Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 552, SaleCode = "table_plasto_bigsquare*1", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 464, SpecialSpriteId = 0, Name = "Square Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 553, SaleCode = "table_plasto_bigsquare*14", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 696, SpecialSpriteId = 0, Name = "Occasional Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 554, SaleCode = "table_plasto_bigsquare*15", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 697, SpecialSpriteId = 0, Name = "Occasional Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 555, SaleCode = "table_plasto_bigsquare*2", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 471, SpecialSpriteId = 0, Name = "Square Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 556, SaleCode = "table_plasto_bigsquare*3", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 478, SpecialSpriteId = 0, Name = "Square Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 557, SaleCode = "table_plasto_bigsquare*4", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 485, SpecialSpriteId = 0, Name = "Square Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 558, SaleCode = "table_plasto_bigsquare*5", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 495, SpecialSpriteId = 0, Name = "Square Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 559, SaleCode = "table_plasto_bigsquare*6", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 500, SpecialSpriteId = 0, Name = "Square Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 560, SaleCode = "table_plasto_bigsquare*7", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 505, SpecialSpriteId = 0, Name = "Square Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 561, SaleCode = "table_plasto_bigsquare*8", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 510, SpecialSpriteId = 0, Name = "Square Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 562, SaleCode = "table_plasto_bigsquare*9", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 515, SpecialSpriteId = 0, Name = "Square Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 563, SaleCode = "table_plasto_round", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 425, SpecialSpriteId = 0, Name = "Round Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 564, SaleCode = "table_plasto_round*1", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 465, SpecialSpriteId = 0, Name = "Round Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 565, SaleCode = "table_plasto_round*14", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 698, SpecialSpriteId = 0, Name = "Occasional Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 566, SaleCode = "table_plasto_round*15", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 699, SpecialSpriteId = 0, Name = "Occasional Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 567, SaleCode = "table_plasto_round*2", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 472, SpecialSpriteId = 0, Name = "Round Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 568, SaleCode = "table_plasto_round*3", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 479, SpecialSpriteId = 0, Name = "Round Dining Table",
            Description = "Hip plastic furniture?"
        },
        new()
        {
            Id = 569, SaleCode = "table_plasto_round*4", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 486, SpecialSpriteId = 0, Name = "Square Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 570, SaleCode = "table_plasto_round*5", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 496, SpecialSpriteId = 0, Name = "Round Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 571, SaleCode = "table_plasto_round*6", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 501, SpecialSpriteId = 0, Name = "Round Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 572, SaleCode = "table_plasto_round*7", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 506, SpecialSpriteId = 0, Name = "Round Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 573, SaleCode = "table_plasto_round*8", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 511, SpecialSpriteId = 0, Name = "Round Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 574, SaleCode = "table_plasto_round*9", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 516, SpecialSpriteId = 0, Name = "Round Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 575, SaleCode = "table_plasto_square", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 440, SpecialSpriteId = 0, Name = "Occasional Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 576, SaleCode = "table_plasto_square*1", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 466, SpecialSpriteId = 0, Name = "Occasional Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 577, SaleCode = "table_plasto_square*14", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 700, SpecialSpriteId = 0, Name = "Occasional Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 578, SaleCode = "table_plasto_square*15", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 701, SpecialSpriteId = 0, Name = "Occasional Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 579, SaleCode = "table_plasto_square*2", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 473, SpecialSpriteId = 0, Name = "Round Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 580, SaleCode = "table_plasto_square*3", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 480, SpecialSpriteId = 0, Name = "Square Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 581, SaleCode = "table_plasto_square*4", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 487, SpecialSpriteId = 0, Name = "Square Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 582, SaleCode = "table_plasto_square*5", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 497, SpecialSpriteId = 0, Name = "Square Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 583, SaleCode = "table_plasto_square*6", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 502, SpecialSpriteId = 0, Name = "Square Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 584, SaleCode = "table_plasto_square*7", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 507, SpecialSpriteId = 0, Name = "Square Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 585, SaleCode = "table_plasto_square*8", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 512, SpecialSpriteId = 0, Name = "Square Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 586, SaleCode = "table_plasto_square*9", PageIds = new List<int> {16}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 517, SpecialSpriteId = 0, Name = "Square Dining Table",
            Description = "Hip plastic furniture"
        },
        new()
        {
            Id = 587, SaleCode = "rubberchair*1", PageIds = new List<int> {43}, SortIndex = 0, Price = 25,
            IsHidden = false, Amount = 1, DefinitionId = 708, SpecialSpriteId = 0, Name = "Blue Inflatable Chair",
            Description = "Soft and stylish HC chair"
        },
        new()
        {
            Id = 588, SaleCode = "rubberchair*2", PageIds = new List<int> {43}, SortIndex = 0, Price = 25,
            IsHidden = false, Amount = 1, DefinitionId = 709, SpecialSpriteId = 0, Name = "Pink Inflatable Chair",
            Description = "Soft and tearproof!"
        },
        new()
        {
            Id = 589, SaleCode = "rubberchair*3", PageIds = new List<int> {43}, SortIndex = 0, Price = 25,
            IsHidden = false, Amount = 1, DefinitionId = 710, SpecialSpriteId = 0, Name = "Orange Inflatable Chair",
            Description = "Soft and tearproof!"
        },
        new()
        {
            Id = 590, SaleCode = "rubberchair*4", PageIds = new List<int> {43}, SortIndex = 0, Price = 25,
            IsHidden = false, Amount = 1, DefinitionId = 711, SpecialSpriteId = 0, Name = "Ocean Inflatable Chair",
            Description = "Soft and tearproof!"
        },
        new()
        {
            Id = 591, SaleCode = "rubberchair*5", PageIds = new List<int> {43}, SortIndex = 0, Price = 25,
            IsHidden = false, Amount = 1, DefinitionId = 712, SpecialSpriteId = 0, Name = "Lime Inflatable Chair",
            Description = "Soft and tearproof!"
        },
        new()
        {
            Id = 592, SaleCode = "rubberchair*6", PageIds = new List<int> {43}, SortIndex = 0, Price = 25,
            IsHidden = false, Amount = 1, DefinitionId = 713, SpecialSpriteId = 0, Name = "Violet Inflatable Chair",
            Description = "Soft and tearproof!"
        },
        new()
        {
            Id = 593, SaleCode = "rubberchair*7", PageIds = new List<int> {43}, SortIndex = 0, Price = 25,
            IsHidden = false, Amount = 1, DefinitionId = 714, SpecialSpriteId = 0, Name = "White Inflatable Chair",
            Description = "Soft and tearproof!"
        },
        new()
        {
            Id = 594, SaleCode = "rubberchair*8", PageIds = new List<int> {43}, SortIndex = 0, Price = 25,
            IsHidden = false, Amount = 1, DefinitionId = 715, SpecialSpriteId = 0, Name = "Black Inflatable Chair",
            Description = "Soft and tearproof for HC!"
        },
        new()
        {
            Id = 595, SaleCode = "spyro", PageIds = new List<int> {44}, SortIndex = 0, Price = 25, IsHidden = false,
            Amount = 1, DefinitionId = 716, SpecialSpriteId = 0, Name = "Dragon Egg",
            Description = "The stuff of legend"
        },
        new()
        {
            Id = 596, SaleCode = "throne", PageIds = new List<int> {44}, SortIndex = 0, Price = 50, IsHidden = false,
            Amount = 1, DefinitionId = 107, SpecialSpriteId = 0, Name = "Throne", Description = "Important Habbos only"
        },
        new()
        {
            Id = 597, SaleCode = "rare_daffodil_rug", PageIds = new List<int> {44}, SortIndex = 0, Price = 25,
            IsHidden = false, Amount = 1, DefinitionId = 717, SpecialSpriteId = 0, Name = "Petal Patch",
            Description = "A little bit of outdoors indoors.."
        },
        new()
        {
            Id = 598, SaleCode = "md_limukaappi", PageIds = new List<int> {44}, SortIndex = 0, Price = 25,
            IsHidden = false, Amount = 1, DefinitionId = 718, SpecialSpriteId = 0, Name = "Habbo Cola Machine",
            Description = "A sparkling and refreshing pixel drink!"
        },
        new()
        {
            Id = 599, SaleCode = "samovar", PageIds = new List<int> {44}, SortIndex = 0, Price = 30, IsHidden = false,
            Amount = 1, DefinitionId = 719, SpecialSpriteId = 0, Name = "Russian Samovar",
            Description = "Click for a refreshing cuppa"
        },
        new()
        {
            Id = 600, SaleCode = "redhologram", PageIds = new List<int> {44}, SortIndex = 0, Price = 20,
            IsHidden = false, Amount = 1, DefinitionId = 720, SpecialSpriteId = 0, Name = "Holo-girl",
            Description = "You're her only hope..."
        },
        new()
        {
            Id = 601, SaleCode = "typingmachine", PageIds = new List<int> {44}, SortIndex = 0, Price = 20,
            IsHidden = false, Amount = 1, DefinitionId = 721, SpecialSpriteId = 0, Name = "Typewriter",
            Description = "Write that bestseller"
        },
        new()
        {
            Id = 602, SaleCode = "hologram", PageIds = new List<int> {44}, SortIndex = 0, Price = 20, IsHidden = false,
            Amount = 1, DefinitionId = 722, SpecialSpriteId = 0, Name = "Holopod", Description = "As if by magic..."
        },
        new()
        {
            Id = 603, SaleCode = "prize1", PageIds = new List<int> {44}, SortIndex = 0, Price = 15, IsHidden = false,
            Amount = 1, DefinitionId = 723, SpecialSpriteId = 0, Name = "Gold Trophy",
            Description = "Gorgeously glittery"
        },
        new()
        {
            Id = 604, SaleCode = "prize2", PageIds = new List<int> {44}, SortIndex = 0, Price = 15, IsHidden = false,
            Amount = 1, DefinitionId = 724, SpecialSpriteId = 0, Name = "Silver Trophy", Description = "Nice and shiny"
        },
        new()
        {
            Id = 605, SaleCode = "prize3", PageIds = new List<int> {44}, SortIndex = 0, Price = 15, IsHidden = false,
            Amount = 1, DefinitionId = 725, SpecialSpriteId = 0, Name = "Bronze Trophy", Description = "A weighty award"
        },
        new()
        {
            Id = 606, SaleCode = "rare_snowrug", PageIds = new List<int> {44}, SortIndex = 0, Price = 25,
            IsHidden = false, Amount = 1, DefinitionId = 726, SpecialSpriteId = 0, Name = "Snow Rug",
            Description = "Chilled Elegance"
        },
        new()
        {
            Id = 607, SaleCode = "poster 1004", PageIds = new List<int> {44}, SortIndex = 1, Price = 25,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 1004, Name = "Eid Mubarak Poster",
            Description = "Celebrate with us"
        },
        new()
        {
            Id = 608, SaleCode = "exe_rug", PageIds = new List<int> {45}, SortIndex = 0, Price = 1, IsHidden = false,
            Amount = 1, DefinitionId = 727, SpecialSpriteId = 0, Name = "Executive Rug",
            Description = "Please remove your shoes!"
        },
        new()
        {
            Id = 609, SaleCode = "exe_s_table", PageIds = new List<int> {45}, SortIndex = 0, Price = 2,
            IsHidden = false, Amount = 1, DefinitionId = 728, SpecialSpriteId = 0, Name = "Executive Glass Table",
            Description = "Get a clear reflection!"
        },
        new()
        {
            Id = 610, SaleCode = "exe_bardesk", PageIds = new List<int> {45}, SortIndex = 0, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 729, SpecialSpriteId = 0, Name = "Executive Bar Desk",
            Description = "Divide the profits!"
        },
        new()
        {
            Id = 611, SaleCode = "exe_chair", PageIds = new List<int> {45}, SortIndex = 0, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 730, SpecialSpriteId = 0, Name = "Executive Sofa Chair",
            Description = "Relaxing leather comfort"
        },
        new()
        {
            Id = 612, SaleCode = "exe_chair2", PageIds = new List<int> {45}, SortIndex = 0, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 731, SpecialSpriteId = 0, Name = "Executive Boss Chair",
            Description = "You're fired!"
        },
        new()
        {
            Id = 613, SaleCode = "exe_corner", PageIds = new List<int> {45}, SortIndex = 0, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 732, SpecialSpriteId = 0, Name = "Executive Corner Desk",
            Description = "Tuck it away"
        },
        new()
        {
            Id = 614, SaleCode = "exe_drinks", PageIds = new List<int> {45}, SortIndex = 0, Price = 2, IsHidden = false,
            Amount = 1, DefinitionId = 733, SpecialSpriteId = 0, Name = "Executive Drinks Tray",
            Description = "Give a warm welcome"
        },
        new()
        {
            Id = 615, SaleCode = "exe_sofa", PageIds = new List<int> {45}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 734, SpecialSpriteId = 0, Name = "3-Seater Sofa",
            Description = "Relaxing leather comfort"
        },
        new()
        {
            Id = 616, SaleCode = "exe_table", PageIds = new List<int> {45}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 735, SpecialSpriteId = 0, Name = "Executive Desk",
            Description = "Take a memo, Featherstone"
        },
        new()
        {
            Id = 617, SaleCode = "exe_plant", PageIds = new List<int> {45}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 736, SpecialSpriteId = 0, Name = "Executive Plant",
            Description = "Shimmering hedge trimming!"
        },
        new()
        {
            Id = 618, SaleCode = "exe_light", PageIds = new List<int> {45}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 737, SpecialSpriteId = 0, Name = "Executive Light",
            Description = "Glow your business"
        },
        new()
        {
            Id = 619, SaleCode = "exe_cubelight", PageIds = new List<int> {45}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 739, SpecialSpriteId = 0, Name = "Cubist Light",
            Description = "Lights up a square"
        },
        new()
        {
            Id = 620, SaleCode = "exe_artlamp", PageIds = new List<int> {45}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 740, SpecialSpriteId = 0, Name = "Sphere Lamp",
            Description = "Suitable for budding entrepreneurs"
        },
        new()
        {
            Id = 621, SaleCode = "exe_map", PageIds = new List<int> {45}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 741, SpecialSpriteId = 0, Name = "World Map",
            Description = "World domination imminent"
        },
        new()
        {
            Id = 622, SaleCode = "exe_wfall", PageIds = new List<int> {45}, SortIndex = 0, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 742, SpecialSpriteId = 0, Name = "Wall Fall",
            Description = "Improve your cash flow"
        },
        new()
        {
            Id = 623, SaleCode = "exe_globe", PageIds = new List<int> {45}, SortIndex = 0, Price = 5, IsHidden = true,
            Amount = 1, DefinitionId = 743, SpecialSpriteId = 0, Name = "Power Globe",
            Description = "The power is yours!"
        },
        new()
        {
            Id = 624, SaleCode = "exe_elevator", PageIds = new List<int> {45}, SortIndex = 0, Price = 7,
            IsHidden = true, Amount = 1, DefinitionId = 744, SpecialSpriteId = 0, Name = "Elevator Teleport",
            Description = "Going up or down in style!"
        },
        new()
        {
            Id = 627, SaleCode = "arabian_bigtb", PageIds = new List<int> {46}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 745, SpecialSpriteId = 0, Name = "Amanjena Table",
            Description = "It must be Jinn-er time!"
        },
        new()
        {
            Id = 628, SaleCode = "arabian_chair", PageIds = new List<int> {46}, SortIndex = 0, Price = 2,
            IsHidden = false, Amount = 1, DefinitionId = 746, SpecialSpriteId = 0, Name = "Green Blossom Chair",
            Description = "Exotic, soft seating"
        },
        new()
        {
            Id = 629, SaleCode = "arabian_divdr", PageIds = new List<int> {46}, SortIndex = 0, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 747, SpecialSpriteId = 0, Name = "Soft wooden screen",
            Description = "Carved Cedar Divider"
        },
        new()
        {
            Id = 630, SaleCode = "arabian_pllw", PageIds = new List<int> {46}, SortIndex = 0, Price = 2,
            IsHidden = false, Amount = 1, DefinitionId = 748, SpecialSpriteId = 0, Name = "Green Blossom Pillow",
            Description = "Exotic comfort"
        },
        new()
        {
            Id = 631, SaleCode = "arabian_rug", PageIds = new List<int> {46}, SortIndex = 0, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 749, SpecialSpriteId = 0, Name = "Berber Kilim Rug",
            Description = "Green blossom design"
        },
        new()
        {
            Id = 632, SaleCode = "arabian_snake", PageIds = new List<int> {46}, SortIndex = 0, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 750, SpecialSpriteId = 0, Name = "Ornamental Urn",
            Description = "Beware the snake!"
        },
        new()
        {
            Id = 633, SaleCode = "arabian_swords", PageIds = new List<int> {46}, SortIndex = 0, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 751, SpecialSpriteId = 0, Name = "Ancestral Scimitars",
            Description = "Not for yielding"
        },
        new()
        {
            Id = 634, SaleCode = "arabian_teamk", PageIds = new List<int> {46}, SortIndex = 0, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 752, SpecialSpriteId = 0, Name = "Tea Maker",
            Description = "Quench that desert thirst"
        },
        new()
        {
            Id = 635, SaleCode = "arabian_tetbl", PageIds = new List<int> {46}, SortIndex = 0, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 753, SpecialSpriteId = 0, Name = "Hexagonal Tea Table",
            Description = "Serve up a treat"
        },
        new()
        {
            Id = 636, SaleCode = "arabian_tray1", PageIds = new List<int> {46}, SortIndex = 0, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 754, SpecialSpriteId = 0, Name = "Mint Tea Tray",
            Description = "Tea for every occasion"
        },
        new()
        {
            Id = 637, SaleCode = "arabian_tray2", PageIds = new List<int> {46}, SortIndex = 0, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 755, SpecialSpriteId = 0, Name = "Candle Tray",
            Description = "For those Arabian nights"
        },
        new()
        {
            Id = 638, SaleCode = "arabian_tray3", PageIds = new List<int> {46}, SortIndex = 0, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 756, SpecialSpriteId = 0, Name = "Sweets Tray",
            Description = "Indulge yourself!"
        },
        new()
        {
            Id = 639, SaleCode = "arabian_tray4", PageIds = new List<int> {46}, SortIndex = 0, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 757, SpecialSpriteId = 0, Name = "Fruit Tray",
            Description = "Sweet, juicy and ripe"
        },
        new()
        {
            Id = 640, SaleCode = "arabian_wndw", PageIds = new List<int> {46}, SortIndex = 0, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 758, SpecialSpriteId = 0, Name = "Arabian Window Frame",
            Description = "Arabian days and nights"
        },
        new()
        {
            Id = 641, SaleCode = "arabian_wall", PageIds = new List<int> {46}, SortIndex = 0, Price = 3,
            IsHidden = true, Amount = 1, DefinitionId = 759, SpecialSpriteId = 0, Name = "Arabian Wall",
            Description = "A wall built with class."
        },
        new()
        {
            Id = 642, SaleCode = "arabian_tile", PageIds = new List<int> {46}, SortIndex = 0, Price = 3,
            IsHidden = true, Amount = 1, DefinitionId = 760, SpecialSpriteId = 0, Name = "Arabian Tile",
            Description = "Step in style..."
        },
        new()
        {
            Id = 674, SaleCode = "teleport_door", PageIds = new List<int> {6}, SortIndex = 3, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 778, SpecialSpriteId = 0, Name = "Teleport Door",
            Description = "Magic doorway to anywhere!"
        },
        new()
        {
            Id = 706, SaleCode = "exe_gate", PageIds = new List<int> {45}, SortIndex = 0, Price = 3, IsHidden = true,
            Amount = 1, DefinitionId = 738, SpecialSpriteId = 0, Name = "Executive Gate",
            Description = "Keeps the tax man away"
        },
        new()
        {
            Id = 772, SaleCode = "chair_norja*2", PageIds = new List<int> {14}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 845, SpecialSpriteId = 0, Name = "Black Iced Chair",
            Description = "Sleek and chic for each cheek"
        },
        new()
        {
            Id = 773, SaleCode = "chair_norja*3", PageIds = new List<int> {14}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 846, SpecialSpriteId = 0, Name = "White Iced Chair",
            Description = "Sleek and chic for each cheek"
        },
        new()
        {
            Id = 774, SaleCode = "chair_norja*4", PageIds = new List<int> {14}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 847, SpecialSpriteId = 0, Name = "Urban Iced Chair",
            Description = "Sleek and chic for each cheek"
        },
        new()
        {
            Id = 775, SaleCode = "chair_norja*5", PageIds = new List<int> {14}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 848, SpecialSpriteId = 0, Name = "Pink Chair",
            Description = "Sleek and chic for each cheek"
        },
        new()
        {
            Id = 776, SaleCode = "chair_norja*6", PageIds = new List<int> {14}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 849, SpecialSpriteId = 0, Name = "Blue Chair",
            Description = "Sleek and chic for each cheek"
        },
        new()
        {
            Id = 777, SaleCode = "chair_norja*7", PageIds = new List<int> {14}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 850, SpecialSpriteId = 0, Name = "Rural Chair",
            Description = "Sleek and chic for each cheek"
        },
        new()
        {
            Id = 778, SaleCode = "chair_norja*8", PageIds = new List<int> {14}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 851, SpecialSpriteId = 0, Name = "Yellow Chair",
            Description = "Sleek and chic for each cheek"
        },
        new()
        {
            Id = 779, SaleCode = "chair_norja*9", PageIds = new List<int> {14}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 852, SpecialSpriteId = 0, Name = "Red Chair",
            Description = "Sleek and chic for each cheek"
        },
        new()
        {
            Id = 780, SaleCode = "couch_norja*2", PageIds = new List<int> {14}, SortIndex = 2, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 853, SpecialSpriteId = 0, Name = "Black Iced Bench",
            Description = "Two can perch comfortably"
        },
        new()
        {
            Id = 781, SaleCode = "couch_norja*3", PageIds = new List<int> {14}, SortIndex = 2, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 854, SpecialSpriteId = 0, Name = "White Iced Bench",
            Description = "Two can perch comfortably"
        },
        new()
        {
            Id = 782, SaleCode = "couch_norja*4", PageIds = new List<int> {14}, SortIndex = 2, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 855, SpecialSpriteId = 0, Name = "Urban Iced Bench",
            Description = "Two can perch comfortably"
        },
        new()
        {
            Id = 783, SaleCode = "couch_norja*5", PageIds = new List<int> {14}, SortIndex = 2, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 856, SpecialSpriteId = 0, Name = "Pink Bench",
            Description = "Two can perch comfortably"
        },
        new()
        {
            Id = 784, SaleCode = "couch_norja*6", PageIds = new List<int> {14}, SortIndex = 2, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 857, SpecialSpriteId = 0, Name = "Blue Bench",
            Description = "Two can perch comfortably"
        },
        new()
        {
            Id = 785, SaleCode = "couch_norja*7", PageIds = new List<int> {14}, SortIndex = 2, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 858, SpecialSpriteId = 0, Name = "Rural Iced Bench",
            Description = "Two can perch comfortably"
        },
        new()
        {
            Id = 786, SaleCode = "couch_norja*8", PageIds = new List<int> {14}, SortIndex = 2, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 859, SpecialSpriteId = 0, Name = "Yellow Bench",
            Description = "Two can perch comfortably"
        },
        new()
        {
            Id = 787, SaleCode = "couch_norja*9", PageIds = new List<int> {14}, SortIndex = 2, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 860, SpecialSpriteId = 0, Name = "Red Bench",
            Description = "Two can perch comfortably"
        },
        new()
        {
            Id = 788, SaleCode = "table_norja_med*2", PageIds = new List<int> {14}, SortIndex = 3, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 861, SpecialSpriteId = 0, Name = "Black Iced Table",
            Description = "For larger gatherings"
        },
        new()
        {
            Id = 789, SaleCode = "table_norja_med*3", PageIds = new List<int> {14}, SortIndex = 3, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 862, SpecialSpriteId = 0, Name = "White Iced Table",
            Description = "For larger gatherings"
        },
        new()
        {
            Id = 790, SaleCode = "table_norja_med*4", PageIds = new List<int> {14}, SortIndex = 3, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 863, SpecialSpriteId = 0, Name = "Urban Iced Coffee Table",
            Description = "For larger gatherings"
        },
        new()
        {
            Id = 791, SaleCode = "table_norja_med*5", PageIds = new List<int> {14}, SortIndex = 3, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 864, SpecialSpriteId = 0, Name = "Large Coffee Table Pink",
            Description = "For larger gatherings"
        },
        new()
        {
            Id = 792, SaleCode = "table_norja_med*6", PageIds = new List<int> {14}, SortIndex = 3, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 865, SpecialSpriteId = 0, Name = "Large Coffee Table Blue",
            Description = "For larger gatherings"
        },
        new()
        {
            Id = 793, SaleCode = "table_norja_med*7", PageIds = new List<int> {14}, SortIndex = 3, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 866, SpecialSpriteId = 0, Name = "Rural Iced Coffee Table",
            Description = "For larger gatherings"
        },
        new()
        {
            Id = 794, SaleCode = "table_norja_med*8", PageIds = new List<int> {14}, SortIndex = 3, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 867, SpecialSpriteId = 0, Name = "Large Coffee Table Yellow",
            Description = "For larger gatherings"
        },
        new()
        {
            Id = 795, SaleCode = "table_norja_med*9", PageIds = new List<int> {14}, SortIndex = 3, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 868, SpecialSpriteId = 0, Name = "Large Coffee Table Red",
            Description = "For larger gatherings"
        },
        new()
        {
            Id = 796, SaleCode = "shelves_norja*2", PageIds = new List<int> {14}, SortIndex = 4, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 869, SpecialSpriteId = 0, Name = "Black Iced Bookcase",
            Description = "For nic naks and art deco books"
        },
        new()
        {
            Id = 797, SaleCode = "shelves_norja*3", PageIds = new List<int> {14}, SortIndex = 4, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 870, SpecialSpriteId = 0, Name = "White Iced Bookcase",
            Description = "For nic naks and art deco books"
        },
        new()
        {
            Id = 798, SaleCode = "shelves_norja*4", PageIds = new List<int> {14}, SortIndex = 4, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 871, SpecialSpriteId = 0, Name = "Urban Iced Bookcase",
            Description = "For nic naks and tech books"
        },
        new()
        {
            Id = 799, SaleCode = "shelves_norja*5", PageIds = new List<int> {14}, SortIndex = 4, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 872, SpecialSpriteId = 0, Name = "Pink Bookcase",
            Description = "For nic naks and art deco books"
        },
        new()
        {
            Id = 800, SaleCode = "shelves_norja*6", PageIds = new List<int> {14}, SortIndex = 4, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 873, SpecialSpriteId = 0, Name = "Blue Bookcase",
            Description = "For nic naks and art deco books"
        },
        new()
        {
            Id = 801, SaleCode = "shelves_norja*7", PageIds = new List<int> {14}, SortIndex = 4, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 874, SpecialSpriteId = 0, Name = "Rural Iced Bookcase",
            Description = "For nic naks and cookery books"
        },
        new()
        {
            Id = 802, SaleCode = "shelves_norja*8", PageIds = new List<int> {14}, SortIndex = 4, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 875, SpecialSpriteId = 0, Name = "Yellow Bookcase",
            Description = "For nic naks and art deco books"
        },
        new()
        {
            Id = 803, SaleCode = "shelves_norja*9", PageIds = new List<int> {14}, SortIndex = 4, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 876, SpecialSpriteId = 0, Name = "Red Bookcase",
            Description = "For nic naks and art deco books"
        },
        new()
        {
            Id = 804, SaleCode = "soft_sofachair_norja*2", PageIds = new List<int> {14}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 877, SpecialSpriteId = 0, Name = "Black Iced Sofachair",
            Description = "Black Iced Sofachair"
        },
        new()
        {
            Id = 805, SaleCode = "soft_sofachair_norja*3", PageIds = new List<int> {14}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 878, SpecialSpriteId = 0, Name = "White Iced Sofachair",
            Description = "Soft Iced sofachair"
        },
        new()
        {
            Id = 806, SaleCode = "soft_sofachair_norja*4", PageIds = new List<int> {14}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 879, SpecialSpriteId = 0, Name = "Urban Iced Sofachair",
            Description = "Sit back and relax"
        },
        new()
        {
            Id = 807, SaleCode = "soft_sofachair_norja*5", PageIds = new List<int> {14}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 880, SpecialSpriteId = 0, Name = "Pink Iced Sofachair",
            Description = "Pink Iced Sofachair"
        },
        new()
        {
            Id = 808, SaleCode = "soft_sofachair_norja*6", PageIds = new List<int> {14}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 881, SpecialSpriteId = 0, Name = "Blue Iced Sofachair",
            Description = "Blue Iced Sofachair"
        },
        new()
        {
            Id = 809, SaleCode = "soft_sofachair_norja*7", PageIds = new List<int> {14}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 882, SpecialSpriteId = 0, Name = "Rural Iced Sofachair",
            Description = "Sit back and relax"
        },
        new()
        {
            Id = 810, SaleCode = "soft_sofachair_norja*8", PageIds = new List<int> {14}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 883, SpecialSpriteId = 0, Name = "Yellow Iced Sofachair",
            Description = "Yellow Iced Sofachair"
        },
        new()
        {
            Id = 811, SaleCode = "soft_sofachair_norja*9", PageIds = new List<int> {14}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 884, SpecialSpriteId = 0, Name = "Red Iced Sofachair",
            Description = "Red Iced Sofachair"
        },
        new()
        {
            Id = 812, SaleCode = "soft_sofa_norja*2", PageIds = new List<int> {14}, SortIndex = 6, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 885, SpecialSpriteId = 0, Name = "Black Iced Sofa",
            Description = "Black Iced Sofa"
        },
        new()
        {
            Id = 813, SaleCode = "soft_sofa_norja*3", PageIds = new List<int> {14}, SortIndex = 6, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 886, SpecialSpriteId = 0, Name = "White Iced Sofa",
            Description = "Pristine white, keep it clean!"
        },
        new()
        {
            Id = 814, SaleCode = "soft_sofa_norja*4", PageIds = new List<int> {14}, SortIndex = 6, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 887, SpecialSpriteId = 0, Name = "Urban Iced Sofa",
            Description = "Sit back and relax"
        },
        new()
        {
            Id = 815, SaleCode = "soft_sofa_norja*5", PageIds = new List<int> {14}, SortIndex = 6, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 888, SpecialSpriteId = 0, Name = "Pink Iced Sofa",
            Description = "Pink Iced Sofa"
        },
        new()
        {
            Id = 816, SaleCode = "soft_sofa_norja*6", PageIds = new List<int> {14}, SortIndex = 6, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 889, SpecialSpriteId = 0, Name = "Blue Iced Sofa",
            Description = "A soft leather sofa"
        },
        new()
        {
            Id = 817, SaleCode = "soft_sofa_norja*7", PageIds = new List<int> {14}, SortIndex = 6, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 890, SpecialSpriteId = 0, Name = "Rural Iced Sofa",
            Description = "Sit back and relax"
        },
        new()
        {
            Id = 818, SaleCode = "soft_sofa_norja*8", PageIds = new List<int> {14}, SortIndex = 6, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 891, SpecialSpriteId = 0, Name = "Yellow Iced Sofa",
            Description = "Yellow Iced Sofa"
        },
        new()
        {
            Id = 819, SaleCode = "soft_sofa_norja*9", PageIds = new List<int> {14}, SortIndex = 6, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 892, SpecialSpriteId = 0, Name = "Red Iced Sofa",
            Description = "Red Iced Sofa"
        },
        new()
        {
            Id = 820, SaleCode = "divider_nor2*2", PageIds = new List<int> {14}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 893, SpecialSpriteId = 0, Name = "Black Iced Bar-Desk",
            Description = "Soft but sturdy"
        },
        new()
        {
            Id = 821, SaleCode = "divider_nor2*3", PageIds = new List<int> {14}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 894, SpecialSpriteId = 0, Name = "White Iced Bar-Desk",
            Description = "Strong, yet soft looking"
        },
        new()
        {
            Id = 822, SaleCode = "divider_nor2*4", PageIds = new List<int> {14}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 895, SpecialSpriteId = 0, Name = "Urban Iced Bar",
            Description = "No way through"
        },
        new()
        {
            Id = 823, SaleCode = "divider_nor2*5", PageIds = new List<int> {14}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 896, SpecialSpriteId = 0, Name = "Pink Iced bar desk",
            Description = "Pink Iced bar desk"
        },
        new()
        {
            Id = 824, SaleCode = "divider_nor2*6", PageIds = new List<int> {14}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 897, SpecialSpriteId = 0, Name = "Blue Iced  bar desk",
            Description = "Blue Iced  bar desk"
        },
        new()
        {
            Id = 825, SaleCode = "divider_nor2*7", PageIds = new List<int> {14}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 898, SpecialSpriteId = 0, Name = "Rural Iced Bar",
            Description = "No way through"
        },
        new()
        {
            Id = 826, SaleCode = "divider_nor2*8", PageIds = new List<int> {14}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 899, SpecialSpriteId = 0, Name = "Yellow Iced  bar desk",
            Description = "Yellow Iced  bar desk"
        },
        new()
        {
            Id = 827, SaleCode = "divider_nor2*9", PageIds = new List<int> {14}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 900, SpecialSpriteId = 0, Name = "Red Iced  bar desk",
            Description = "Red Iced  bar desk"
        },
        new()
        {
            Id = 828, SaleCode = "divider_nor1*2", PageIds = new List<int> {14}, SortIndex = 8, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 901, SpecialSpriteId = 0, Name = "Black Iced Corner",
            Description = "Tuck it away"
        },
        new()
        {
            Id = 829, SaleCode = "divider_nor1*3", PageIds = new List<int> {14}, SortIndex = 8, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 902, SpecialSpriteId = 0, Name = "White Iced Corner",
            Description = "Looks squishy, but isn't!"
        },
        new()
        {
            Id = 830, SaleCode = "divider_nor1*4", PageIds = new List<int> {14}, SortIndex = 8, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 903, SpecialSpriteId = 0, Name = "Urban Iced Corner",
            Description = "The missing piece"
        },
        new()
        {
            Id = 831, SaleCode = "divider_nor1*5", PageIds = new List<int> {14}, SortIndex = 8, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 904, SpecialSpriteId = 0, Name = "Pink Ice corner",
            Description = "Pink Ice corner"
        },
        new()
        {
            Id = 832, SaleCode = "divider_nor1*6", PageIds = new List<int> {14}, SortIndex = 8, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 905, SpecialSpriteId = 0, Name = "Blue Ice corner",
            Description = "Blue Ice corner"
        },
        new()
        {
            Id = 833, SaleCode = "divider_nor1*7", PageIds = new List<int> {14}, SortIndex = 8, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 906, SpecialSpriteId = 0, Name = "Rural Iced Corner",
            Description = "The missing piece"
        },
        new()
        {
            Id = 834, SaleCode = "divider_nor1*8", PageIds = new List<int> {14}, SortIndex = 8, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 907, SpecialSpriteId = 0, Name = "Yellow Ice corner",
            Description = "Yellow Ice corner"
        },
        new()
        {
            Id = 835, SaleCode = "divider_nor1*9", PageIds = new List<int> {14}, SortIndex = 8, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 908, SpecialSpriteId = 0, Name = "Red Ice corner",
            Description = "Red Ice corner"
        },
        new()
        {
            Id = 836, SaleCode = "divider_nor3*2", PageIds = new List<int> {14}, SortIndex = 9, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 909, SpecialSpriteId = 0, Name = "Black Iced Gate",
            Description = "No way through, or is there?"
        },
        new()
        {
            Id = 837, SaleCode = "divider_nor3*3", PageIds = new List<int> {14}, SortIndex = 9, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 910, SpecialSpriteId = 0, Name = "White Iced Gate",
            Description = "Do go through..."
        },
        new()
        {
            Id = 838, SaleCode = "divider_nor3*4", PageIds = new List<int> {14}, SortIndex = 9, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 911, SpecialSpriteId = 0, Name = "Urban Iced Gate",
            Description = "Entrance or exit?"
        },
        new()
        {
            Id = 839, SaleCode = "divider_nor3*5", PageIds = new List<int> {14}, SortIndex = 9, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 912, SpecialSpriteId = 0, Name = "Pink Iced gate",
            Description = "Pink Iced gate"
        },
        new()
        {
            Id = 840, SaleCode = "divider_nor3*6", PageIds = new List<int> {14}, SortIndex = 9, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 913, SpecialSpriteId = 0, Name = "Blue Iced gate",
            Description = "Blue Iced gate"
        },
        new()
        {
            Id = 841, SaleCode = "divider_nor3*7", PageIds = new List<int> {14}, SortIndex = 9, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 914, SpecialSpriteId = 0, Name = "Rural Iced gate",
            Description = "Entrance or exit?"
        },
        new()
        {
            Id = 842, SaleCode = "divider_nor3*8", PageIds = new List<int> {14}, SortIndex = 9, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 915, SpecialSpriteId = 0, Name = "Yellow Iced gate",
            Description = "Yellow Iced gate"
        },
        new()
        {
            Id = 843, SaleCode = "divider_nor3*9", PageIds = new List<int> {14}, SortIndex = 9, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 916, SpecialSpriteId = 0, Name = "Red Iced gate",
            Description = "Red Iced gate"
        },
        new()
        {
            Id = 844, SaleCode = "divider_nor4*2", PageIds = new List<int> {14}, SortIndex = 10, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 917, SpecialSpriteId = 0, Name = "Black Iced Auto Shutter",
            Description = "Habbos, roll out!"
        },
        new()
        {
            Id = 845, SaleCode = "divider_nor4*3", PageIds = new List<int> {14}, SortIndex = 10, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 918, SpecialSpriteId = 0, Name = "White Iced Auto Shutter",
            Description = "Habbos, roll out!"
        },
        new()
        {
            Id = 846, SaleCode = "divider_nor4*4", PageIds = new List<int> {14}, SortIndex = 10, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 919, SpecialSpriteId = 0, Name = "Urban Iced Shutter",
            Description = "Habbos, roll out!"
        },
        new()
        {
            Id = 847, SaleCode = "divider_nor4*5", PageIds = new List<int> {14}, SortIndex = 10, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 920, SpecialSpriteId = 0, Name = "Pink Iced Auto Shutter",
            Description = "Habbos, roll out!"
        },
        new()
        {
            Id = 848, SaleCode = "divider_nor4*6", PageIds = new List<int> {14}, SortIndex = 10, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 921, SpecialSpriteId = 0, Name = "Blue Iced Auto Shutter",
            Description = "Habbos, roll out!"
        },
        new()
        {
            Id = 849, SaleCode = "divider_nor4*7", PageIds = new List<int> {14}, SortIndex = 10, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 922, SpecialSpriteId = 0, Name = "Rural Iced Shutter",
            Description = "Habbos, roll out!"
        },
        new()
        {
            Id = 850, SaleCode = "divider_nor4*8", PageIds = new List<int> {14}, SortIndex = 10, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 923, SpecialSpriteId = 0, Name = "Yellow Iced Auto Shutter",
            Description = "Habbos, roll out!"
        },
        new()
        {
            Id = 851, SaleCode = "divider_nor4*9", PageIds = new List<int> {14}, SortIndex = 10, Price = 5,
            IsHidden = false, Amount = 1, DefinitionId = 924, SpecialSpriteId = 0, Name = "Red Iced Auto Shutter",
            Description = "Habbos, roll out!"
        },
        new()
        {
            Id = 852, SaleCode = "divider_nor5*2", PageIds = new List<int> {14}, SortIndex = 11, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 925, SpecialSpriteId = 0, Name = "Black Iced Angle",
            Description = "Cool cornering for your crib y0!"
        },
        new()
        {
            Id = 853, SaleCode = "divider_nor5*3", PageIds = new List<int> {14}, SortIndex = 11, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 926, SpecialSpriteId = 0, Name = "White Iced Angle",
            Description = "Cool cornering for your crib y0!"
        },
        new()
        {
            Id = 854, SaleCode = "divider_nor5*4", PageIds = new List<int> {14}, SortIndex = 11, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 927, SpecialSpriteId = 0, Name = "Urban Iced Angle",
            Description = "Cool cornering for your crib!"
        },
        new()
        {
            Id = 855, SaleCode = "divider_nor5*5", PageIds = new List<int> {14}, SortIndex = 11, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 928, SpecialSpriteId = 0, Name = "Pink Iced Angle",
            Description = "Cool cornering for your crib y0!"
        },
        new()
        {
            Id = 856, SaleCode = "divider_nor5*6", PageIds = new List<int> {14}, SortIndex = 11, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 929, SpecialSpriteId = 0, Name = "Blue Iced Angle",
            Description = "Cool cornering for your crib y0!"
        },
        new()
        {
            Id = 857, SaleCode = "divider_nor5*7", PageIds = new List<int> {14}, SortIndex = 11, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 930, SpecialSpriteId = 0, Name = "Rural Iced Angle",
            Description = "Cool cornering for your crib!"
        },
        new()
        {
            Id = 858, SaleCode = "divider_nor5*8", PageIds = new List<int> {14}, SortIndex = 11, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 931, SpecialSpriteId = 0, Name = "Yellow Iced Angle",
            Description = "Cool cornering for your crib y0!"
        },
        new()
        {
            Id = 859, SaleCode = "divider_nor5*9", PageIds = new List<int> {14}, SortIndex = 11, Price = 4,
            IsHidden = false, Amount = 1, DefinitionId = 932, SpecialSpriteId = 0, Name = "Red Iced Angle",
            Description = "Cool cornering for your crib y0!"
        },
        new()
        {
            Id = 860, SaleCode = "sofa_silo*2", PageIds = new List<int> {9}, SortIndex = 4, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 933, SpecialSpriteId = 0, Name = "Black Two-Seater Sofa",
            Description = "Cushioned, understated comfort"
        },
        new()
        {
            Id = 861, SaleCode = "sofa_silo*3", PageIds = new List<int> {9}, SortIndex = 4, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 934, SpecialSpriteId = 0, Name = "White Two-Seater Sofa",
            Description = "Cushioned, understated comfort"
        },
        new()
        {
            Id = 862, SaleCode = "sofa_silo*4", PageIds = new List<int> {9}, SortIndex = 4, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 935, SpecialSpriteId = 0, Name = "Beige Area Sofa",
            Description = "Beige Area Sofa"
        },
        new()
        {
            Id = 863, SaleCode = "sofa_silo*5", PageIds = new List<int> {9}, SortIndex = 4, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 936, SpecialSpriteId = 0, Name = "Pink Area Sofa",
            Description = "Cushioned, understated comfort"
        },
        new()
        {
            Id = 864, SaleCode = "sofa_silo*6", PageIds = new List<int> {9}, SortIndex = 4, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 937, SpecialSpriteId = 0, Name = "Blue Area Sofa",
            Description = "Cushioned, understated comfort"
        },
        new()
        {
            Id = 865, SaleCode = "sofa_silo*7", PageIds = new List<int> {9}, SortIndex = 4, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 938, SpecialSpriteId = 0, Name = "Green Area Sofa",
            Description = "Cushioned, understated comfort"
        },
        new()
        {
            Id = 866, SaleCode = "sofa_silo*8", PageIds = new List<int> {9}, SortIndex = 4, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 939, SpecialSpriteId = 0, Name = "Yellow Two-Seater Sofa",
            Description = "Cushioned, understated comfort"
        },
        new()
        {
            Id = 867, SaleCode = "sofa_silo*9", PageIds = new List<int> {9}, SortIndex = 4, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 940, SpecialSpriteId = 0, Name = "Red Area Sofa",
            Description = "Cushioned, understated comfort"
        },
        new()
        {
            Id = 868, SaleCode = "sofachair_silo*2", PageIds = new List<int> {9}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 941, SpecialSpriteId = 0, Name = "Black Armchair",
            Description = "Large, but worth it"
        },
        new()
        {
            Id = 869, SaleCode = "sofachair_silo*3", PageIds = new List<int> {9}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 942, SpecialSpriteId = 0, Name = "White Armchair",
            Description = "Large, but worth it"
        },
        new()
        {
            Id = 870, SaleCode = "sofachair_silo*4", PageIds = new List<int> {9}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 943, SpecialSpriteId = 0, Name = "Beige Area Armchair",
            Description = "Large, but worth it"
        },
        new()
        {
            Id = 871, SaleCode = "sofachair_silo*5", PageIds = new List<int> {9}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 944, SpecialSpriteId = 0, Name = "Pink Area Armchair",
            Description = "Large, but worth it"
        },
        new()
        {
            Id = 872, SaleCode = "sofachair_silo*6", PageIds = new List<int> {9}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 945, SpecialSpriteId = 0, Name = "Blue Area Armchair",
            Description = "Large, but worth it"
        },
        new()
        {
            Id = 873, SaleCode = "sofachair_silo*7", PageIds = new List<int> {9}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 946, SpecialSpriteId = 0, Name = "Green Area Armchair",
            Description = "Large, but worth it"
        },
        new()
        {
            Id = 874, SaleCode = "sofachair_silo*8", PageIds = new List<int> {9}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 947, SpecialSpriteId = 0, Name = "Yellow Armchair",
            Description = "Large, but worth it"
        },
        new()
        {
            Id = 875, SaleCode = "sofachair_silo*9", PageIds = new List<int> {9}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 948, SpecialSpriteId = 0, Name = "Red Area Armchair",
            Description = "Large, but worth it"
        },
        new()
        {
            Id = 876, SaleCode = "table_silo_small*2", PageIds = new List<int> {9}, SortIndex = 6, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 949, SpecialSpriteId = 0, Name = "Black Occasional Table",
            Description = "For those random moments"
        },
        new()
        {
            Id = 877, SaleCode = "table_silo_small*3", PageIds = new List<int> {9}, SortIndex = 6, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 950, SpecialSpriteId = 0, Name = "White Occasional Table",
            Description = "For those random moments"
        },
        new()
        {
            Id = 878, SaleCode = "table_silo_small*4", PageIds = new List<int> {9}, SortIndex = 6, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 951, SpecialSpriteId = 0, Name = "Beige Area Occasional Table",
            Description = "Beige Area Occasional Table"
        },
        new()
        {
            Id = 879, SaleCode = "table_silo_small*5", PageIds = new List<int> {9}, SortIndex = 6, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 952, SpecialSpriteId = 0, Name = "Pink Area Occasional Table",
            Description = "Pink Area Occasional Table"
        },
        new()
        {
            Id = 880, SaleCode = "table_silo_small*6", PageIds = new List<int> {9}, SortIndex = 6, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 953, SpecialSpriteId = 0, Name = "Blue Area Occasional Table",
            Description = "Small and elegant"
        },
        new()
        {
            Id = 881, SaleCode = "table_silo_small*7", PageIds = new List<int> {9}, SortIndex = 6, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 954, SpecialSpriteId = 0, Name = "Green Area Occasional Table",
            Description = "Small and elegant"
        },
        new()
        {
            Id = 882, SaleCode = "table_silo_small*8", PageIds = new List<int> {9}, SortIndex = 6, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 955, SpecialSpriteId = 0, Name = "Yellow Occasional Table",
            Description = "For those random moments"
        },
        new()
        {
            Id = 883, SaleCode = "table_silo_small*9", PageIds = new List<int> {9}, SortIndex = 6, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 956, SpecialSpriteId = 0, Name = "Red Area Occasional Table",
            Description = "Red Area Occasional Table"
        },
        new()
        {
            Id = 884, SaleCode = "divider_silo3*2", PageIds = new List<int> {9}, SortIndex = 7, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 957, SpecialSpriteId = 0, Name = "Black Area Gate",
            Description = "Form following function"
        },
        new()
        {
            Id = 885, SaleCode = "divider_silo3*3", PageIds = new List<int> {9}, SortIndex = 7, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 958, SpecialSpriteId = 0, Name = "White Area Gate",
            Description = "Form following function"
        },
        new()
        {
            Id = 886, SaleCode = "divider_silo3*4", PageIds = new List<int> {9}, SortIndex = 7, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 959, SpecialSpriteId = 0, Name = "Beige Area Gate",
            Description = "Beige Area Gate"
        },
        new()
        {
            Id = 887, SaleCode = "divider_silo3*5", PageIds = new List<int> {9}, SortIndex = 7, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 960, SpecialSpriteId = 0, Name = "Pink Area Gate",
            Description = "Pink Area Gate"
        },
        new()
        {
            Id = 888, SaleCode = "divider_silo3*6", PageIds = new List<int> {9}, SortIndex = 7, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 961, SpecialSpriteId = 0, Name = "Blue Area Gate",
            Description = "Door (lockable)"
        },
        new()
        {
            Id = 889, SaleCode = "divider_silo3*7", PageIds = new List<int> {9}, SortIndex = 7, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 962, SpecialSpriteId = 0, Name = "Green Area Gate",
            Description = "Door (lockable)"
        },
        new()
        {
            Id = 890, SaleCode = "divider_silo3*8", PageIds = new List<int> {9}, SortIndex = 7, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 963, SpecialSpriteId = 0, Name = "Yellow Area Gate",
            Description = "Form following function"
        },
        new()
        {
            Id = 891, SaleCode = "divider_silo3*9", PageIds = new List<int> {9}, SortIndex = 7, Price = 6,
            IsHidden = false, Amount = 1, DefinitionId = 964, SpecialSpriteId = 0, Name = "Red Area Gate",
            Description = "Red Area Gate"
        },
        new()
        {
            Id = 892, SaleCode = "divider_silo1*2", PageIds = new List<int> {9}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 965, SpecialSpriteId = 0, Name = "Black Corner Shelf",
            Description = "Neat and natty"
        },
        new()
        {
            Id = 893, SaleCode = "divider_silo1*3", PageIds = new List<int> {9}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 966, SpecialSpriteId = 0, Name = "White Corner Shelf",
            Description = "Neat and natty"
        },
        new()
        {
            Id = 894, SaleCode = "divider_silo1*4", PageIds = new List<int> {9}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 967, SpecialSpriteId = 0, Name = "Beige Area Corner Shelf",
            Description = "Beige Area Corner Shelf"
        },
        new()
        {
            Id = 895, SaleCode = "divider_silo1*5", PageIds = new List<int> {9}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 968, SpecialSpriteId = 0, Name = "Pink Area Corner Shelf",
            Description = "Pink Area Corner Shelf"
        },
        new()
        {
            Id = 896, SaleCode = "divider_silo1*6", PageIds = new List<int> {9}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 967, SpecialSpriteId = 0, Name = "Blue Area Corner Shelf",
            Description = "Tuck it away!"
        },
        new()
        {
            Id = 897, SaleCode = "divider_silo1*7", PageIds = new List<int> {9}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 968, SpecialSpriteId = 0, Name = "Green Area Corner Shelf",
            Description = "Tuck it away!"
        },
        new()
        {
            Id = 898, SaleCode = "divider_silo1*8", PageIds = new List<int> {9}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 969, SpecialSpriteId = 0, Name = "Yellow Corner Shelf",
            Description = "Neat and natty"
        },
        new()
        {
            Id = 899, SaleCode = "divider_silo1*9", PageIds = new List<int> {9}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 970, SpecialSpriteId = 0, Name = "Red Area Corner Shelf",
            Description = "Tuck it away"
        },
        new()
        {
            Id = 900, SaleCode = "chair_silo*2", PageIds = new List<int> {9}, SortIndex = 10, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 973, SpecialSpriteId = 0, Name = "Black Dining Chair",
            Description = "Keep it simple"
        },
        new()
        {
            Id = 901, SaleCode = "chair_silo*3", PageIds = new List<int> {9}, SortIndex = 10, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 974, SpecialSpriteId = 0, Name = "White Dining Chair",
            Description = "Keep it simple"
        },
        new()
        {
            Id = 902, SaleCode = "chair_silo*4", PageIds = new List<int> {9}, SortIndex = 10, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 975, SpecialSpriteId = 0, Name = "Beige Silo Dining Chair",
            Description = "Beige Silo Dining Chair"
        },
        new()
        {
            Id = 903, SaleCode = "chair_silo*5", PageIds = new List<int> {9}, SortIndex = 10, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 976, SpecialSpriteId = 0, Name = "Pink Silo Dining Chair",
            Description = "Pink Silo Dining Chair"
        },
        new()
        {
            Id = 904, SaleCode = "chair_silo*6", PageIds = new List<int> {9}, SortIndex = 10, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 977, SpecialSpriteId = 0, Name = "Blue Area Dining Chair",
            Description = "Wooden dining chair"
        },
        new()
        {
            Id = 905, SaleCode = "chair_silo*7", PageIds = new List<int> {9}, SortIndex = 10, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 978, SpecialSpriteId = 0, Name = "Green Area Dining Chair",
            Description = "Wooden dining chair"
        },
        new()
        {
            Id = 906, SaleCode = "chair_silo*8", PageIds = new List<int> {9}, SortIndex = 10, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 979, SpecialSpriteId = 0, Name = "Yellow Dining Chair",
            Description = "Keep it simple"
        },
        new()
        {
            Id = 907, SaleCode = "chair_silo*9", PageIds = new List<int> {9}, SortIndex = 10, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 980, SpecialSpriteId = 0, Name = "Red Area Dining Chair",
            Description = "Wooden dining chair"
        },
        new()
        {
            Id = 908, SaleCode = "safe_silo*2", PageIds = new List<int> {9}, SortIndex = 11, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 981, SpecialSpriteId = 0, Name = "Black Safe Minibar",
            Description = "Totally shatter-proof!"
        },
        new()
        {
            Id = 909, SaleCode = "safe_silo*3", PageIds = new List<int> {9}, SortIndex = 11, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 982, SpecialSpriteId = 0, Name = "White Safe Minibar",
            Description = "Totally shatter-proof!"
        },
        new()
        {
            Id = 910, SaleCode = "safe_silo*4", PageIds = new List<int> {9}, SortIndex = 11, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 983, SpecialSpriteId = 0, Name = "Beige Safe Minibar",
            Description = "Totally shatter-proof!"
        },
        new()
        {
            Id = 911, SaleCode = "safe_silo*5", PageIds = new List<int> {9}, SortIndex = 11, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 984, SpecialSpriteId = 0, Name = "Pink Safe Minibar",
            Description = "Totally shatter-proof!"
        },
        new()
        {
            Id = 912, SaleCode = "safe_silo*6", PageIds = new List<int> {9}, SortIndex = 11, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 985, SpecialSpriteId = 0, Name = "Blue Safe Minibar",
            Description = "Totally shatter-proof!"
        },
        new()
        {
            Id = 913, SaleCode = "safe_silo*7", PageIds = new List<int> {9}, SortIndex = 11, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 986, SpecialSpriteId = 0, Name = "Green Safe Minibar",
            Description = "Totally shatter-proof!"
        },
        new()
        {
            Id = 914, SaleCode = "safe_silo*8", PageIds = new List<int> {9}, SortIndex = 11, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 987, SpecialSpriteId = 0, Name = "Yellow Safe Minibar",
            Description = "Totally shatter-proof!"
        },
        new()
        {
            Id = 915, SaleCode = "safe_silo*9", PageIds = new List<int> {9}, SortIndex = 11, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 988, SpecialSpriteId = 0, Name = "Red Safe Minibar",
            Description = "Totally shatter-proof!"
        },
        new()
        {
            Id = 916, SaleCode = "barchair_silo*2", PageIds = new List<int> {9}, SortIndex = 12, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 989, SpecialSpriteId = 0, Name = "Black Bar Stool",
            Description = "Practical and convenient"
        },
        new()
        {
            Id = 917, SaleCode = "barchair_silo*3", PageIds = new List<int> {9}, SortIndex = 12, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 990, SpecialSpriteId = 0, Name = "White Bar Stool",
            Description = "Practical and convenient"
        },
        new()
        {
            Id = 918, SaleCode = "barchair_silo*4", PageIds = new List<int> {9}, SortIndex = 12, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 991, SpecialSpriteId = 0, Name = "Beige Bar Stool",
            Description = "Practical and convenient"
        },
        new()
        {
            Id = 919, SaleCode = "barchair_silo*5", PageIds = new List<int> {9}, SortIndex = 12, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 992, SpecialSpriteId = 0, Name = "Pink Bar Stool",
            Description = "Practical and convenient"
        },
        new()
        {
            Id = 920, SaleCode = "barchair_silo*6", PageIds = new List<int> {9}, SortIndex = 12, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 993, SpecialSpriteId = 0, Name = "Blue Bar Stool",
            Description = "Take a perch!"
        },
        new()
        {
            Id = 921, SaleCode = "barchair_silo*7", PageIds = new List<int> {9}, SortIndex = 12, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 994, SpecialSpriteId = 0, Name = "Green Bar Stool",
            Description = "Take a perch!"
        },
        new()
        {
            Id = 922, SaleCode = "barchair_silo*8", PageIds = new List<int> {9}, SortIndex = 12, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 995, SpecialSpriteId = 0, Name = "Yellow Bar Stool",
            Description = "Practical and convenient"
        },
        new()
        {
            Id = 923, SaleCode = "barchair_silo*9", PageIds = new List<int> {9}, SortIndex = 12, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 996, SpecialSpriteId = 0, Name = "Red Bar Stool",
            Description = "Practical and convenient"
        },
        new()
        {
            Id = 924, SaleCode = "table_silo_med*2", PageIds = new List<int> {9}, SortIndex = 13, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 997, SpecialSpriteId = 0, Name = "Black Coffee Table",
            Description = "Wipe clean and unobtrusive"
        },
        new()
        {
            Id = 925, SaleCode = "table_silo_med*3", PageIds = new List<int> {9}, SortIndex = 13, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 998, SpecialSpriteId = 0, Name = "White Coffee Table",
            Description = "Wipe clean and unobtrusive"
        },
        new()
        {
            Id = 926, SaleCode = "table_silo_med*4", PageIds = new List<int> {9}, SortIndex = 13, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 999, SpecialSpriteId = 0, Name = "Beige Area Coffee Table",
            Description = "Beige Area Coffee Table"
        },
        new()
        {
            Id = 927, SaleCode = "table_silo_med*5", PageIds = new List<int> {9}, SortIndex = 13, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1000, SpecialSpriteId = 0, Name = "Pink Area Coffee Table",
            Description = "Pink Area Coffee Table"
        },
        new()
        {
            Id = 928, SaleCode = "table_silo_med*6", PageIds = new List<int> {9}, SortIndex = 13, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1001, SpecialSpriteId = 0, Name = "Blue Area Coffee Table",
            Description = "Gather everyone round"
        },
        new()
        {
            Id = 929, SaleCode = "table_silo_med*7", PageIds = new List<int> {9}, SortIndex = 13, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1002, SpecialSpriteId = 0, Name = "Green Area Coffee Table",
            Description = "Gather everyone round"
        },
        new()
        {
            Id = 930, SaleCode = "table_silo_med*8", PageIds = new List<int> {9}, SortIndex = 13, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1003, SpecialSpriteId = 0, Name = "Yellow Coffee Table",
            Description = "Wipe clean and unobtrusive"
        },
        new()
        {
            Id = 931, SaleCode = "table_silo_med*9", PageIds = new List<int> {9}, SortIndex = 13, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1004, SpecialSpriteId = 0, Name = "Red Area Coffee Table",
            Description = "Red Area Coffee Table"
        },
        new()
        {
            Id = 932, SaleCode = "pura_mdl1*1", PageIds = new List<int> {17}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1005, SpecialSpriteId = 0, Name = "Aqua Pura Module 1",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 933, SaleCode = "pura_mdl2*1", PageIds = new List<int> {17}, SortIndex = 8, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1006, SpecialSpriteId = 0, Name = "Aqua Pura Module 2",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 934, SaleCode = "pura_mdl3*1", PageIds = new List<int> {17}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1007, SpecialSpriteId = 0, Name = "Aqua Pura Module 3",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 935, SaleCode = "pura_mdl4*1", PageIds = new List<int> {17}, SortIndex = 10, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1008, SpecialSpriteId = 0, Name = "Aqua Pura Module 4",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 936, SaleCode = "pura_mdl5*1", PageIds = new List<int> {17}, SortIndex = 11, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1009, SpecialSpriteId = 0, Name = "Aqua Pura Module 5",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 937, SaleCode = "chair_basic*1", PageIds = new List<int> {17}, SortIndex = 12, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1010, SpecialSpriteId = 0, Name = "Aqua Pura Egg Chair",
            Description = "It's a cracking design!"
        },
        new()
        {
            Id = 938, SaleCode = "pura_mdl1*2", PageIds = new List<int> {17}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1011, SpecialSpriteId = 0, Name = "Pink Pura Module 1",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 939, SaleCode = "pura_mdl1*3", PageIds = new List<int> {17}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1012, SpecialSpriteId = 0, Name = "Black Pura Module 1",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 940, SaleCode = "pura_mdl1*4", PageIds = new List<int> {17}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1013, SpecialSpriteId = 0, Name = "White Pura Module 1",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 941, SaleCode = "pura_mdl1*5", PageIds = new List<int> {17}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1014, SpecialSpriteId = 0, Name = "Beige pura module 1",
            Description = ""
        },
        new()
        {
            Id = 942, SaleCode = "pura_mdl1*6", PageIds = new List<int> {17}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1015, SpecialSpriteId = 0, Name = "Blue Pura Module 1",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 943, SaleCode = "pura_mdl1*7", PageIds = new List<int> {17}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1016, SpecialSpriteId = 0, Name = "Green Pura Module 1",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 944, SaleCode = "pura_mdl1*8", PageIds = new List<int> {17}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1017, SpecialSpriteId = 0, Name = "Yellow pura module 1",
            Description = ""
        },
        new()
        {
            Id = 945, SaleCode = "pura_mdl1*9", PageIds = new List<int> {17}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1018, SpecialSpriteId = 0, Name = "Red Pura Module 1",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 946, SaleCode = "pura_mdl2*2", PageIds = new List<int> {17}, SortIndex = 8, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1019, SpecialSpriteId = 0, Name = "Pink Pura Module 2",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 947, SaleCode = "pura_mdl2*3", PageIds = new List<int> {17}, SortIndex = 8, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1020, SpecialSpriteId = 0, Name = "Black Pura Module 2",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 948, SaleCode = "pura_mdl2*4", PageIds = new List<int> {17}, SortIndex = 8, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1021, SpecialSpriteId = 0, Name = "White Pura Module 2",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 949, SaleCode = "pura_mdl2*5", PageIds = new List<int> {17}, SortIndex = 8, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1022, SpecialSpriteId = 0, Name = "Beige pura module 2",
            Description = ""
        },
        new()
        {
            Id = 950, SaleCode = "pura_mdl2*6", PageIds = new List<int> {17}, SortIndex = 8, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1023, SpecialSpriteId = 0, Name = "Blue Pura Module 2",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 951, SaleCode = "pura_mdl2*7", PageIds = new List<int> {17}, SortIndex = 8, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1024, SpecialSpriteId = 0, Name = "Green Pura Module 2",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 952, SaleCode = "pura_mdl2*8", PageIds = new List<int> {17}, SortIndex = 8, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1025, SpecialSpriteId = 0, Name = "Yellow pura module 2",
            Description = ""
        },
        new()
        {
            Id = 953, SaleCode = "pura_mdl2*9", PageIds = new List<int> {17}, SortIndex = 8, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1026, SpecialSpriteId = 0, Name = "Red Pura Module 2",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 954, SaleCode = "pura_mdl3*2", PageIds = new List<int> {17}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1027, SpecialSpriteId = 0, Name = "Pink Pura Module 3",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 955, SaleCode = "pura_mdl3*3", PageIds = new List<int> {17}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1028, SpecialSpriteId = 0, Name = "Black Pura Module 3",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 956, SaleCode = "pura_mdl3*4", PageIds = new List<int> {17}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1029, SpecialSpriteId = 0, Name = "White Pura Module 3",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 957, SaleCode = "pura_mdl3*5", PageIds = new List<int> {17}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1030, SpecialSpriteId = 0, Name = "Beige pura module 3",
            Description = ""
        },
        new()
        {
            Id = 958, SaleCode = "pura_mdl3*6", PageIds = new List<int> {17}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1031, SpecialSpriteId = 0, Name = "Blue Pura Module 3",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 959, SaleCode = "pura_mdl3*7", PageIds = new List<int> {17}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1032, SpecialSpriteId = 0, Name = "Green Pura Module 3",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 960, SaleCode = "pura_mdl3*8", PageIds = new List<int> {17}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1033, SpecialSpriteId = 0, Name = "Yellow pura module 3",
            Description = ""
        },
        new()
        {
            Id = 961, SaleCode = "pura_mdl3*9", PageIds = new List<int> {17}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1034, SpecialSpriteId = 0, Name = "Red Pura Module 3",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 962, SaleCode = "pura_mdl4*2", PageIds = new List<int> {17}, SortIndex = 10, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1035, SpecialSpriteId = 0, Name = "Pink Pura Module 4",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 963, SaleCode = "pura_mdl4*3", PageIds = new List<int> {17}, SortIndex = 10, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1036, SpecialSpriteId = 0, Name = "Black Pura Module 4",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 964, SaleCode = "pura_mdl4*4", PageIds = new List<int> {17}, SortIndex = 10, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1037, SpecialSpriteId = 0, Name = "White Pura Module 4",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 965, SaleCode = "pura_mdl4*5", PageIds = new List<int> {17}, SortIndex = 10, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1038, SpecialSpriteId = 0, Name = "Beige pura module 4",
            Description = ""
        },
        new()
        {
            Id = 966, SaleCode = "pura_mdl4*6", PageIds = new List<int> {17}, SortIndex = 10, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1039, SpecialSpriteId = 0, Name = "Blue Pura Module 4",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 967, SaleCode = "pura_mdl4*7", PageIds = new List<int> {17}, SortIndex = 10, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1040, SpecialSpriteId = 0, Name = "Green Pura Module 4",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 968, SaleCode = "pura_mdl4*8", PageIds = new List<int> {17}, SortIndex = 10, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1041, SpecialSpriteId = 0, Name = "Yellow pura module 4",
            Description = ""
        },
        new()
        {
            Id = 969, SaleCode = "pura_mdl4*9", PageIds = new List<int> {17}, SortIndex = 10, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1042, SpecialSpriteId = 0, Name = "Red Pura Module 4",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 970, SaleCode = "pura_mdl5*2", PageIds = new List<int> {17}, SortIndex = 11, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1043, SpecialSpriteId = 0, Name = "Pink Pura Module 5",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 971, SaleCode = "pura_mdl5*3", PageIds = new List<int> {17}, SortIndex = 11, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1044, SpecialSpriteId = 0, Name = "Black Pura Module 5",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 972, SaleCode = "pura_mdl5*4", PageIds = new List<int> {17}, SortIndex = 11, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1045, SpecialSpriteId = 0, Name = "White Pura Module 5",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 973, SaleCode = "pura_mdl5*5", PageIds = new List<int> {17}, SortIndex = 11, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1046, SpecialSpriteId = 0, Name = "Beige pura module 5",
            Description = ""
        },
        new()
        {
            Id = 974, SaleCode = "pura_mdl5*6", PageIds = new List<int> {17}, SortIndex = 11, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1047, SpecialSpriteId = 0, Name = "Blue Pura Module 5",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 975, SaleCode = "pura_mdl5*7", PageIds = new List<int> {17}, SortIndex = 11, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1048, SpecialSpriteId = 0, Name = "Green Pura Module 5",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 976, SaleCode = "pura_mdl5*8", PageIds = new List<int> {17}, SortIndex = 11, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1049, SpecialSpriteId = 0, Name = "Yellow Pura Module 5",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 977, SaleCode = "pura_mdl5*9", PageIds = new List<int> {17}, SortIndex = 11, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1050, SpecialSpriteId = 0, Name = "Red Pura Module 5",
            Description = "Any way you like it!"
        },
        new()
        {
            Id = 978, SaleCode = "chair_basic*2", PageIds = new List<int> {17}, SortIndex = 12, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1051, SpecialSpriteId = 0, Name = "Pink Pura Egg Chair",
            Description = "It's a cracking design!"
        },
        new()
        {
            Id = 979, SaleCode = "chair_basic*3", PageIds = new List<int> {17}, SortIndex = 12, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1052, SpecialSpriteId = 0, Name = "Black Pura Egg Chair",
            Description = "It's a cracking design!"
        },
        new()
        {
            Id = 980, SaleCode = "chair_basic*4", PageIds = new List<int> {17}, SortIndex = 12, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1053, SpecialSpriteId = 0, Name = "White Pura Egg Chair",
            Description = "It's a cracking design!"
        },
        new()
        {
            Id = 981, SaleCode = "chair_basic*5", PageIds = new List<int> {17}, SortIndex = 12, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1054, SpecialSpriteId = 0, Name = "Beige Pura Egg Chair",
            Description = "It's a cracking design!"
        },
        new()
        {
            Id = 982, SaleCode = "chair_basic*6", PageIds = new List<int> {17}, SortIndex = 12, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1055, SpecialSpriteId = 0, Name = "Blue Pura Egg Chair",
            Description = "It's a cracking design!"
        },
        new()
        {
            Id = 983, SaleCode = "chair_basic*7", PageIds = new List<int> {17}, SortIndex = 12, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1056, SpecialSpriteId = 0, Name = "Green Pura Egg Chair",
            Description = "It's a cracking design!"
        },
        new()
        {
            Id = 984, SaleCode = "chair_basic*8", PageIds = new List<int> {17}, SortIndex = 12, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1057, SpecialSpriteId = 0, Name = "Yellow Pura Egg Chair",
            Description = "It's a cracking design!"
        },
        new()
        {
            Id = 985, SaleCode = "chair_basic*9", PageIds = new List<int> {17}, SortIndex = 12, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1058, SpecialSpriteId = 0, Name = "Red Pura Egg Chair",
            Description = "It's a cracking design!"
        },
        new()
        {
            Id = 986, SaleCode = "hcc_chair", PageIds = new List<int> {64}, SortIndex = 1, Price = 8, IsHidden = false,
            Amount = 1, DefinitionId = 1060, SpecialSpriteId = 0, Name = "Trendy Stool",
            Description = "Shiny varnished finish"
        },
        new()
        {
            Id = 987, SaleCode = "hcc_shelf", PageIds = new List<int> {64}, SortIndex = 6, Price = 8, IsHidden = false,
            Amount = 1, DefinitionId = 1061, SpecialSpriteId = 0, Name = "Bookshelf",
            Description = "Your own Habbo archives"
        },
        new()
        {
            Id = 988, SaleCode = "hcc_stool", PageIds = new List<int> {64}, SortIndex = 2, Price = 8, IsHidden = false,
            Amount = 1, DefinitionId = 1062, SpecialSpriteId = 0, Name = "Antique Stool",
            Description = "For larger gatherings"
        },
        new()
        {
            Id = 989, SaleCode = "hcc_dvdr", PageIds = new List<int> {64}, SortIndex = 8, Price = 8, IsHidden = false,
            Amount = 1, DefinitionId = 1063, SpecialSpriteId = 0, Name = "Glass Divider",
            Description = "It won't cramp your style"
        },
        new()
        {
            Id = 990, SaleCode = "hcc_sofa", PageIds = new List<int> {64}, SortIndex = 4, Price = 8, IsHidden = false,
            Amount = 1, DefinitionId = 1068, SpecialSpriteId = 0, Name = "Low Back Sofa",
            Description = "Get your friends over!"
        },
        new()
        {
            Id = 991, SaleCode = "hcc_crnr", PageIds = new List<int> {64}, SortIndex = 9, Price = 8, IsHidden = false,
            Amount = 1, DefinitionId = 1065, SpecialSpriteId = 0, Name = "Glass Corner",
            Description = "Adds the finishing touch"
        },
        new()
        {
            Id = 992, SaleCode = "hcc_sofachair", PageIds = new List<int> {64}, SortIndex = 3, Price = 8,
            IsHidden = false, Amount = 1, DefinitionId = 1064, SpecialSpriteId = 0, Name = "Reclining Chair",
            Description = "Put your feet up!"
        },
        new()
        {
            Id = 993, SaleCode = "hcc_table", PageIds = new List<int> {64}, SortIndex = 5, Price = 8, IsHidden = false,
            Amount = 1, DefinitionId = 1066, SpecialSpriteId = 0, Name = "Glass Table",
            Description = "Elegant centre piece"
        },
        new()
        {
            Id = 994, SaleCode = "hcc_minibar", PageIds = new List<int> {64}, SortIndex = 7, Price = 8,
            IsHidden = false, Amount = 1, DefinitionId = 1067, SpecialSpriteId = 0, Name = "Minibar",
            Description = "Cool look, cool drinks!"
        },
        new()
        {
            Id = 1037, SaleCode = "romantique_pianochair*1", PageIds = new List<int> {68}, SortIndex = 2, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1111, SpecialSpriteId = 0, Name = "Rose Quartz Piano Chair",
            Description = "Elegant seating for elegant Habbos"
        },
        new()
        {
            Id = 1038, SaleCode = "romantique_divan*1", PageIds = new List<int> {68}, SortIndex = 3, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1112, SpecialSpriteId = 0, Name = "Chaise-Longue",
            Description = "Recline in continental Rose Quartz comfort"
        },
        new()
        {
            Id = 1039, SaleCode = "romantique_chair*1", PageIds = new List<int> {68}, SortIndex = 4, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1113, SpecialSpriteId = 0, Name = "Rose Quartz Chair",
            Description = "Elegant seating for elegant Habbos"
        },
        new()
        {
            Id = 1040, SaleCode = "romantique_divider*1", PageIds = new List<int> {68}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1114, SpecialSpriteId = 0, Name = "Rose Quartz Screen",
            Description = "Beauty lies within"
        },
        new()
        {
            Id = 1041, SaleCode = "romantique_smalltabl*1", PageIds = new List<int> {68}, SortIndex = 6, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1115, SpecialSpriteId = 0, Name = "Rose Quartz Tray Table",
            Description = "Every tray needs a table..."
        },
        new()
        {
            Id = 1042, SaleCode = "romantique_mirrortabl", PageIds = new List<int> {68}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1116, SpecialSpriteId = 0, Name = "Dressing Table",
            Description = "Get ready for your big date"
        },
        new()
        {
            Id = 1043, SaleCode = "wallmirror", PageIds = new List<int> {68}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1117, SpecialSpriteId = 0, Name = "Wallmirror",
            Description = "Mirror, mirror on the wall..."
        },
        new()
        {
            Id = 1044, SaleCode = "romantique_tray1", PageIds = new List<int> {68}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1118, SpecialSpriteId = 0, Name = "Romantique Tray",
            Description = "Breakfast is served!"
        },
        new()
        {
            Id = 1045, SaleCode = "romantique_tray2", PageIds = new List<int> {68}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1119, SpecialSpriteId = 0, Name = "Romantique Treats Tray",
            Description = "Time to celebrate!"
        },
        new()
        {
            Id = 1046, SaleCode = "rom_lamp", PageIds = new List<int> {68}, SortIndex = 1, Price = 3, IsHidden = false,
            Amount = 1, DefinitionId = 1120, SpecialSpriteId = 0, Name = "Crystal Lamp",
            Description = "Light up your life"
        },
        new()
        {
            Id = 1047, SaleCode = "romantique_clock", PageIds = new List<int> {68}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1121, SpecialSpriteId = 0, Name = "Grandfather's Clock",
            Description = "The most Romantic tick-tock ever!"
        },
        new()
        {
            Id = 1048, SaleCode = "romantique_pianochair*2", PageIds = new List<int> {68}, SortIndex = 2, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1122, SpecialSpriteId = 0,
            Name = "Lime Romantique Piano Chair", Description = "Sit in traditional style"
        },
        new()
        {
            Id = 1049, SaleCode = "romantique_divan*2", PageIds = new List<int> {68}, SortIndex = 3, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1123, SpecialSpriteId = 0, Name = "Emerald Chaise-Longue",
            Description = "Recline in continental comfort"
        },
        new()
        {
            Id = 1050, SaleCode = "romantique_chair*2", PageIds = new List<int> {68}, SortIndex = 4, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1124, SpecialSpriteId = 0, Name = "Lime Romantique Chair",
            Description = "None"
        },
        new()
        {
            Id = 1051, SaleCode = "romantique_divider*2", PageIds = new List<int> {68}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1125, SpecialSpriteId = 0, Name = "Green Screen",
            Description = "Keeping things separated"
        },
        new()
        {
            Id = 1052, SaleCode = "romantique_smalltabl*2", PageIds = new List<int> {68}, SortIndex = 6, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1126, SpecialSpriteId = 0, Name = "Lime Tray Table",
            Description = "Every tray needs a table..."
        },
        new()
        {
            Id = 1053, SaleCode = "romantique_pianochair*3", PageIds = new List<int> {68}, SortIndex = 2, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1127, SpecialSpriteId = 0, Name = "Sapphire Chair",
            Description = "For stately seating experiences"
        },
        new()
        {
            Id = 1054, SaleCode = "romantique_divan*3", PageIds = new List<int> {68}, SortIndex = 3, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1128, SpecialSpriteId = 0, Name = "Turquoise Romantique Divan",
            Description = "None"
        },
        new()
        {
            Id = 1055, SaleCode = "romantique_chair*3", PageIds = new List<int> {68}, SortIndex = 4, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1129, SpecialSpriteId = 0, Name = "Turquoise Romantique Chair",
            Description = "None"
        },
        new()
        {
            Id = 1056, SaleCode = "romantique_divider*3", PageIds = new List<int> {68}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1130, SpecialSpriteId = 0, Name = "Turquoise Screen",
            Description = "Keeping things separated"
        },
        new()
        {
            Id = 1057, SaleCode = "romantique_smalltabl*3", PageIds = new List<int> {68}, SortIndex = 6, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1131, SpecialSpriteId = 0, Name = "Turquoise Tray Table",
            Description = "Every tray needs a table..."
        },
        new()
        {
            Id = 1058, SaleCode = "romantique_pianochair*4", PageIds = new List<int> {68}, SortIndex = 2, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1132, SpecialSpriteId = 0, Name = "Amber Piano Stool",
            Description = "I can feel air coming through..."
        },
        new()
        {
            Id = 1059, SaleCode = "romantique_divan*4", PageIds = new List<int> {68}, SortIndex = 3, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1133, SpecialSpriteId = 0, Name = "Amber Chaise-Longue",
            Description = "Is that a cape hanging there?"
        },
        new()
        {
            Id = 1060, SaleCode = "romantique_chair*4", PageIds = new List<int> {68}, SortIndex = 4, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1134, SpecialSpriteId = 0, Name = "Amber Chair",
            Description = "What does this button do?"
        },
        new()
        {
            Id = 1061, SaleCode = "romantique_divider*4", PageIds = new List<int> {68}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1135, SpecialSpriteId = 0, Name = "Ochre Screen",
            Description = "Keeping things separated"
        },
        new()
        {
            Id = 1062, SaleCode = "romantique_smalltabl*4", PageIds = new List<int> {68}, SortIndex = 6, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1136, SpecialSpriteId = 0, Name = "Amber Tray Table",
            Description = "Why is one leg different?"
        },
        new()
        {
            Id = 1063, SaleCode = "romantique_pianochair*5", PageIds = new List<int> {68}, SortIndex = 2, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1137, SpecialSpriteId = 0, Name = "Onyx Piano Stool",
            Description = "I can feel air coming through..."
        },
        new()
        {
            Id = 1064, SaleCode = "romantique_divan*5", PageIds = new List<int> {68}, SortIndex = 3, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1138, SpecialSpriteId = 0, Name = "Onyx Chaise-Longue",
            Description = "Is that a cape hanging there?"
        },
        new()
        {
            Id = 1065, SaleCode = "romantique_chair*5", PageIds = new List<int> {68}, SortIndex = 4, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1139, SpecialSpriteId = 0, Name = "Onyx Chair",
            Description = "What does this button do?"
        },
        new()
        {
            Id = 1066, SaleCode = "romantique_divider*5", PageIds = new List<int> {68}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1140, SpecialSpriteId = 0, Name = "Romantique Screen Gray",
            Description = "Keeping Things Separated"
        },
        new()
        {
            Id = 1067, SaleCode = "romantique_smalltabl*6", PageIds = new List<int> {68}, SortIndex = 6, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1141, SpecialSpriteId = 0, Name = "", Description = ""
        },
        new()
        {
            Id = 1068, SaleCode = "grand_piano*1", PageIds = new List<int> {68}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1142, SpecialSpriteId = 0, Name = "Turquoise Grand Piano",
            Description = "Turquoise Grand Piano"
        },
        new()
        {
            Id = 1069, SaleCode = "grand_piano*2", PageIds = new List<int> {68}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1143, SpecialSpriteId = 0, Name = "Esmerald Piano Stool",
            Description = "Let the music begin"
        },
        new()
        {
            Id = 1070, SaleCode = "grand_piano*3", PageIds = new List<int> {68}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1144, SpecialSpriteId = 0, Name = "Sapphire Piano Stool",
            Description = "Make sure you play in key!"
        },
        new()
        {
            Id = 1071, SaleCode = "grand_piano*4", PageIds = new List<int> {68}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1145, SpecialSpriteId = 0, Name = "Amber Grand Piano",
            Description = "Why is that key green?"
        },
        new()
        {
            Id = 1072, SaleCode = "grand_piano*5", PageIds = new List<int> {68}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1146, SpecialSpriteId = 0, Name = "Onyx Grand Piano",
            Description = "Why is that key green?"
        },
        new()
        {
            Id = 1274, SaleCode = "grunge_barrel", PageIds = new List<int> {81}, SortIndex = 1, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1363, SpecialSpriteId = 0, Name = "Flaming Barrel",
            Description = "Beacon of light!"
        },
        new()
        {
            Id = 1275, SaleCode = "grunge_bench", PageIds = new List<int> {81}, SortIndex = 2, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1364, SpecialSpriteId = 0, Name = "Bench",
            Description = "Laid back seating"
        },
        new()
        {
            Id = 1276, SaleCode = "grunge_candle", PageIds = new List<int> {81}, SortIndex = 3, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1365, SpecialSpriteId = 0, Name = "Candle Box",
            Description = "Late night debate"
        },
        new()
        {
            Id = 1277, SaleCode = "grunge_chair", PageIds = new List<int> {81}, SortIndex = 4, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1366, SpecialSpriteId = 0, Name = "Grunge Chair",
            Description = "Alternative chair for alternative people"
        },
        new()
        {
            Id = 1278, SaleCode = "grunge_mattress", PageIds = new List<int> {81}, SortIndex = 5, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1367, SpecialSpriteId = 0, Name = "Grunge Mattress",
            Description = "Beats sleeping on the floor!"
        },
        new()
        {
            Id = 1279, SaleCode = "grunge_radiator", PageIds = new List<int> {81}, SortIndex = 6, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1368, SpecialSpriteId = 0, Name = "Radiator",
            Description = "Started cool but now it's hot!"
        },
        new()
        {
            Id = 1280, SaleCode = "grunge_shelf", PageIds = new List<int> {81}, SortIndex = 7, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1369, SpecialSpriteId = 0, Name = "Grunge Bookshelf",
            Description = "Scrap books and photo albums"
        },
        new()
        {
            Id = 1281, SaleCode = "grunge_sign", PageIds = new List<int> {81}, SortIndex = 8, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1370, SpecialSpriteId = 0, Name = "Road Sign",
            Description = "Bought legitimately from an M1 cafe."
        },
        new()
        {
            Id = 1282, SaleCode = "grunge_table", PageIds = new List<int> {81}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1371, SpecialSpriteId = 0, Name = "Grunge Table",
            Description = "Students of the round table!"
        },
        new()
        {
            Id = 1283, SaleCode = "hc_crpt", PageIds = new List<int> {27}, SortIndex = 2, Price = 5, IsHidden = false,
            Amount = 1, DefinitionId = 1372, SpecialSpriteId = 0, Name = "Persian Carpet",
            Description = "Ultimate craftsmanship"
        },
        new()
        {
            Id = 1284, SaleCode = "poster 12", PageIds = new List<int> {24}, SortIndex = 21, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 12, Name = "Lapland Poster",
            Description = "a beautiful sunset"
        },
        new()
        {
            Id = 1285, SaleCode = "poster 35", PageIds = new List<int> {24}, SortIndex = 23, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 35, Name = "The Habbo Babes 1",
            Description = "The Hotel's girlband. Dream on!"
        },
        new()
        {
            Id = 1286, SaleCode = "poster 36", PageIds = new List<int> {24}, SortIndex = 24, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 36, Name = "The Habbo Babes 2",
            Description = "The Hotels girlband. Dream on!"
        },
        new()
        {
            Id = 1287, SaleCode = "poster 37", PageIds = new List<int> {24}, SortIndex = 25, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 37, Name = "The Habbo Babes 3",
            Description = "The Hotels girlband. Dream on!"
        },
        new()
        {
            Id = 1288, SaleCode = "poster 2006", PageIds = new List<int> {24}, SortIndex = 26, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 2006, Name = "DJ Throne",
            Description = "He is the magic Habbo"
        },
        new()
        {
            Id = 1289, SaleCode = "poster 13", PageIds = new List<int> {24}, SortIndex = 22, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 13, Name = "BW Skyline Poster",
            Description = "Arty black and white"
        },
        new()
        {
            Id = 1290, SaleCode = "poster 39", PageIds = new List<int> {24}, SortIndex = 27, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 39, Name = "Screaming Furnies",
            Description = "The rock masters of virtual music"
        },
        new()
        {
            Id = 1291, SaleCode = "poster 41", PageIds = new List<int> {24}, SortIndex = 28, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 41, Name = "Habbo Golden Record",
            Description = "For the best music-makers"
        },
        new()
        {
            Id = 1292, SaleCode = "poster 34", PageIds = new List<int> {24}, SortIndex = 29, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 34, Name = "Scamme'd",
            Description = "Habbo-punk for the never-agreeing"
        },
        new()
        {
            Id = 1293, SaleCode = "poster 1005", PageIds = new List<int> {24}, SortIndex = 30, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 1005, Name = "Johnny Squabble",
            Description = "The muscly movie hero"
        },
        new()
        {
            Id = 1294, SaleCode = "poster 2001", PageIds = new List<int> {24}, SortIndex = 31, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 2001, Name = "Magic Carpet",
            Description = "Former servant of a great wizard!"
        },
        new()
        {
            Id = 1295, SaleCode = "poster 20", PageIds = new List<int> {24}, SortIndex = 32, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 20, Name = "Snowman Poster",
            Description = "A new use for carrots!"
        },
        new()
        {
            Id = 1296, SaleCode = "poster 24", PageIds = new List<int> {24}, SortIndex = 33, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 24, Name = "Three Wise Men Poster",
            Description = "Following the star"
        },
        new()
        {
            Id = 1297, SaleCode = "poster 1003", PageIds = new List<int> {24}, SortIndex = 34, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 1003, Name = "UK Map",
            Description = "get the lovely isles on your walls"
        },
        new()
        {
            Id = 1298, SaleCode = "poster 31", PageIds = new List<int> {24}, SortIndex = 35, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 31, Name = "System of a Ban",
            Description = "Pure and unbridled nu-metal"
        },
        new()
        {
            Id = 1299, SaleCode = "poster 38", PageIds = new List<int> {24}, SortIndex = 35, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 38, Name = "Smiling Headbangerz",
            Description = "For really TOUGH Habbos!"
        },
        new()
        {
            Id = 1300, SaleCode = "poster 40", PageIds = new List<int> {24}, SortIndex = 35, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 40, Name = "Bonnie Blonde",
            Description = "The one and only. Adore her!"
        },
        new()
        {
            Id = 1301, SaleCode = "poster 1001", PageIds = new List<int> {24}, SortIndex = 35, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 1001, Name = "Prince Charles Poster",
            Description = "even walls have ears"
        },
        new()
        {
            Id = 1302, SaleCode = "poster 1002", PageIds = new List<int> {24}, SortIndex = 35, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 1002, Name = "Queen Mum Poster",
            Description = "aw, bless..."
        },
        new()
        {
            Id = 1303, SaleCode = "poster 2000", PageIds = new List<int> {24}, SortIndex = 35, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 2000, Name = "Suomen kartta",
            Description = "Suomen kartta"
        },
        new()
        {
            Id = 1304, SaleCode = "poster 2002", PageIds = new List<int> {24}, SortIndex = 35, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 2002, Name = "Urho Kaleva Kekkonen",
            Description = "Presidentin muotokuva"
        },
        new()
        {
            Id = 1305, SaleCode = "poster 2003", PageIds = new List<int> {24}, SortIndex = 35, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 2003, Name = "Dodgy Geezer",
            Description = "Would you trust this man?"
        },
        new()
        {
            Id = 1306, SaleCode = "poster 2004", PageIds = new List<int> {24}, SortIndex = 35, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 2004, Name = "Rasta Poster",
            Description = "irie!"
        },
        new()
        {
            Id = 1307, SaleCode = "poster 2007", PageIds = new List<int> {24}, SortIndex = 35, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 251, SpecialSpriteId = 2007, Name = "The Father Of Habbo",
            Description = "The legendary founder of the Hotel"
        },
        new()
        {
            Id = 1338, SaleCode = "fortune", PageIds = new List<int> {19}, SortIndex = 5, Price = 10, IsHidden = false,
            Amount = 1, DefinitionId = 1403, SpecialSpriteId = 0, Name = "Crystal Ball",
            Description = "Gaze into the future"
        },
        new()
        {
            Id = 1339, SaleCode = "sound_machine", PageIds = new List<int> {84}, SortIndex = 1, Price = 8,
            IsHidden = false, Amount = 1, DefinitionId = 232, SpecialSpriteId = 0, Name = "Sound Machine",
            Description = "Creating fancy sounds"
        },
        new()
        {
            Id = 1340, SaleCode = "sound_set_65", PageIds = new List<int> {88}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1404, SpecialSpriteId = 0, Name = "Tiki anthems",
            Description = "Tiki drums go boom!"
        },
        new()
        {
            Id = 1341, SaleCode = "sound_set_66", PageIds = new List<int> {88}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1405, SpecialSpriteId = 0, Name = "Tiki Trax",
            Description = "Spin some island tunes"
        },
        new()
        {
            Id = 1342, SaleCode = "sound_set_67", PageIds = new List<int> {88}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1406, SpecialSpriteId = 0, Name = "The trax of Tiki",
            Description = "Appease the greatest Habboa with party songs"
        },
        new()
        {
            Id = 1343, SaleCode = "sound_set_68", PageIds = new List<int> {88}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1407, SpecialSpriteId = 0, Name = "Pitchside Pro",
            Description = "Football Sounds 1"
        },
        new()
        {
            Id = 1344, SaleCode = "sound_set_69", PageIds = new List<int> {88}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1408, SpecialSpriteId = 0, Name = "Referee Rhythm",
            Description = "Football Sounds 2"
        },
        new()
        {
            Id = 1345, SaleCode = "sound_set_70", PageIds = new List<int> {88}, SortIndex = 9, Price = 3,
            IsHidden = false, Amount = 1, DefinitionId = 1409, SpecialSpriteId = 0, Name = "Squad Synth",
            Description = "Football Sounds 3"
        },
        new()
        {
            Id = 1348, SaleCode = "rclr_chair", PageIds = new List<int> {92}, SortIndex = 9, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 1414, SpecialSpriteId = 0, Name = "Palm Chair",
            Description = "Watch out for coconuts"
        },
        new()
        {
            Id = 1349, SaleCode = "rclr_garden", PageIds = new List<int> {92}, SortIndex = 9, Price = 1,
            IsHidden = false, Amount = 1, DefinitionId = 1415, SpecialSpriteId = 0, Name = "Water Garden",
            Description = "Self watering"
        },
        new()
        {
            Id = 1350, SaleCode = "rclr_sofa", PageIds = new List<int> {92}, SortIndex = 9, Price = 1, IsHidden = false,
            Amount = 1, DefinitionId = 1416, SpecialSpriteId = 0, Name = "Polar Sofa",
            Description = "Snuggle up together"
        }
    };
}