using System.ComponentModel.DataAnnotations;

namespace Snouthill.Database.Models;

public class RoomModel
{
    [Key] public int Id { get; set; }

    public int Category { get; set; } = 2;

    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;

    public string LayoutName { get; set; } = null!;
    public string FileNames { get; set; } = "";

    public int Wallpaper { get; set; } = 0;
    public int Floor { get; set; } = 0;

    public string? OwnerName { get; set; } = null;
    public bool ShowOwnerName { get; set; } = true;

    public int CurrentVisitors { get; set; } = 0;
    public int MaxVisitors { get; set; } = 25;

    public bool ShowName { get; set; } = false;
    public bool HideFromNavigator { get; set; } = false;
}