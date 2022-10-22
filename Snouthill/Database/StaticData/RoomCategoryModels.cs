using Snouthill.Database.Models;

namespace Snouthill.Database.StaticData;

public class RoomCategoryModels
{
    public static readonly IEnumerable<RoomCategoryModel> Models = new List<RoomCategoryModel>
    {
        new()
        {
            Id = 2, ParentCategoryId = 0, Name = "No Category",
            PublicSpaces = false, AllowTrading = false
        },
        new()
        {
            Id = 3, ParentCategoryId = 0, Name = "Public Rooms",
            PublicSpaces = true, AllowTrading = false
        },
        new()
        {
            Id = 4, ParentCategoryId = 0, Name = "Guest Rooms",
            PublicSpaces = false, AllowTrading = false
        },
        new()
        {
            Id = 5, ParentCategoryId = 3, Name = "Entertainment",
            PublicSpaces = true, AllowTrading = false
        },
        new()
        {
            Id = 6, ParentCategoryId = 3, Name = "Restaurants and Cafes",
            PublicSpaces = true, AllowTrading = false
        },
        new()
        {
            Id = 7, ParentCategoryId = 3, Name = "Lounges and Clubs",
            PublicSpaces = true, AllowTrading = false
        },
        new()
        {
            Id = 8, ParentCategoryId = 3, Name = "Club-only Spaces",
            PublicSpaces = true, AllowTrading = false
        },
        new()
        {
            Id = 9, ParentCategoryId = 3, Name = "Parks and Gardens",
            PublicSpaces = true, AllowTrading = false
        },
        new()
        {
            Id = 10, ParentCategoryId = 3, Name = "Swimming Pools",
            PublicSpaces = true, AllowTrading = false
        },
        new()
        {
            Id = 11, ParentCategoryId = 3, Name = "The Lobbies",
            PublicSpaces = true, AllowTrading = false
        },
        new()
        {
            Id = 12, ParentCategoryId = 3, Name = "The Hallways",
            PublicSpaces = true, AllowTrading = false
        },
        new()
        {
            Id = 13, ParentCategoryId = 3, Name = "Games",
            PublicSpaces = true, AllowTrading = false
        },
        new()
        {
            Id = 101, ParentCategoryId = 4, Name = "Staff HQ",
            PublicSpaces = false, AllowTrading = false
        },
        new()
        {
            Id = 112, ParentCategoryId = 4, Name = "Restaurant, Bar & Night Club Rooms",
            PublicSpaces = false, AllowTrading = false
        },
        new()
        {
            Id = 113, ParentCategoryId = 4, Name = "Trade Floor",
            PublicSpaces = false, AllowTrading = true
        },
        new()
        {
            Id = 114, ParentCategoryId = 4, Name = "Chill, Chat & Discussion Rooms",
            PublicSpaces = false, AllowTrading = false
        },
        new()
        {
            Id = 115, ParentCategoryId = 4, Name = "Hair Salons & Modelling Rooms",
            PublicSpaces = false, AllowTrading = false
        },
        new()
        {
            Id = 116, ParentCategoryId = 4, Name = "Maze & Theme Park Rooms",
            PublicSpaces = false, AllowTrading = false
        },
        new()
        {
            Id = 117, ParentCategoryId = 4, Name = "Gaming & Race Rooms",
            PublicSpaces = false, AllowTrading = false
        },
        new()
        {
            Id = 118, ParentCategoryId = 4, Name = "Help Centre Rooms",
            PublicSpaces = false, AllowTrading = false
        },
        new()
        {
            Id = 120, ParentCategoryId = 4, Name = "Miscellaneous",
            PublicSpaces = false, AllowTrading = false
        }
    };
}