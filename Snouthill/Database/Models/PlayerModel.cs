using System.ComponentModel.DataAnnotations;

namespace Snouthill.Database.Models;

public class PlayerModel
{
    [Key] public int PlayerId { get; set; }
    
    public string Name { get; set; } = null!;
    public string Password { get; set; } = null!;
    
    public string Email { get; set; } = null!;
    public string Birthday { get; set; } = null!;
    public string Motto { get; set; } = "";
    public string Sex { get; set; } = null!;
    public string Figure { get; set; } = null!;
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
}