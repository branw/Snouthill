namespace Snouthill.Database.Models;

public class BadgeModel
{
    public string Name { get; set; } = null!;

    public int OwnerPlayerId { get; set; } = 0;
}