namespace Snouthill.Game;

public abstract class AEntity
{
    public abstract Room? Room { get; set; }

    public void Talk(TalkLevel level, string message, IEnumerable<string>? recipientNames = null)
    {
        if (Room == null) return;

        foreach (var player in Room.GetEntities<Player>())
        {
        }
    }
}