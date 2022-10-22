using System.ComponentModel.DataAnnotations;

namespace Snouthill.Database.Models;

public class RoomCategoryModel
{
    [Key] public int Id { get; set; }

    public int ParentCategoryId { get; set; }

    public bool IsNode { get; set; } = false;

    public string Name { get; set; } = null!;

    public bool PublicSpaces { get; set; } = false;

    public bool AllowTrading { get; set; } = false;
}