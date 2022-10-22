using System.ComponentModel.DataAnnotations;

namespace Snouthill.Database.Models;

public class PublicItemModel
{
    [Key] public int Id { get; set; }

    public string RoomLayoutName { get; set; } = null!;

    public string SpriteName { get; set; } = null!;

    public int X { get; set; } = 0;
    public int Y { get; set; } = 0;
    public double Z { get; set; } = 0;
    public int Rotation { get; set; } = 0;

    public double TopHeight { get; set; } = 1;
    public int Length { get; set; } = 1;
    public int Width { get; set; } = 1;

    public string? BehaviorFlags { get; set; } = null;
    public string? CurrentProgram { get; set; } = null;
}