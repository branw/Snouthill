using System.ComponentModel.DataAnnotations;

namespace Snouthill.Db.Models;

public class RoomModel
{
    [Key] public int Id { get; set; }

    public string OwnerName { get; set; }

    public int Category { get; set; } = 2;

    public string Name { get; set; }
    public string Description { get; set; }

    public string LayoutName { get; set; }
    public string FileNames { get; set; } = "";

    public int Wallpaper { get; set; } = 0;
    public int Floor { get; set; } = 0;

    public bool ShowOwnerName { get; set; } = true;

    public int CurrentVisitors { get; set; } = 0;
    public int MaxVisitors { get; set; } = 25;
}