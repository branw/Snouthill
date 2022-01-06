using System.ComponentModel.DataAnnotations;

namespace Snouthill.Db.Models;

public class PlayerModel
{
    [Key] public string Name { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Birthday { get; set; }
    public string Motto { get; set; } = "";
    public string Sex { get; set; }
    public string Figure { get; set; }
    public string SwimsuitFigure { get; set; } = "";

    public bool Superuser { get; set; } = false;

    public string CurrentBadge { get; set; } = "";
    public bool ShowBadge { get; set; } = false;

    public int Credits { get; set; } = 0;
    public int Tickets { get; set; } = 0;

    public int ClubExpiration { get; set; } = 0;

    public int Film { get; set; } = 0;

    public bool SoundEnabled { get; set; } = true;
    public bool TutorialCompleted { get; set; } = false;

    public static PlayerModel? FindByName(string name)
    {
        using var db = new DatabaseContext();
        return db.Players.Find(name);
    }
}