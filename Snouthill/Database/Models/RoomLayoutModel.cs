using System.ComponentModel.DataAnnotations;

namespace Snouthill.Database.Models;

public class RoomLayoutModel
{
    [Key] public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public int DoorX { get; set; } = 0;
    public int DoorY { get; set; } = 0;
    public double DoorZ { get; set; }
    public int DoorDirection { get; set; } = 2;

    public string HeightMap { get; set; } = null!;
}