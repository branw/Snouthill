using Snouthill.Networking;
using Snouthill.Networking.Messages.Room;
using Snouthill.Networking.Messages.Room.Players;

namespace Snouthill.Game;

public abstract class AEntity
{
    public int EntityId { get; set; } = 0;
    
    public abstract Room? Room { get; internal set; }

    public (int X, int Y, double Z) Position { get; set; } = (0, 0, 0);

    public LinkedList<(int X, int Y)> Path { get; set; } = new();

    public Dictionary<EntityStatus, string?> Statuses = new();

    public bool Dirty { get; set; } = false;
    
    public void WalkTo(int x, int y)
    {
        if (Room == null)
            throw new PlayerNotInRoomException();

        //Path = Pathfinder.MakePath(this, x, y);

        Position = (x, y, 0);
        Room.Send(new UserStatuses(Room.Entities));
    }
    
    public void Talk(TalkLevel level, string message, IEnumerable<string>? recipientNames = null)
    {
        if (Room == null) return;

        //TODO skip ignored players
        foreach (var player in Room.GetEntities<Player>())
        {

            switch (level)
            {
                default:
                case TalkLevel.Chat:
                    player.Send(new ShoutMessage(EntityId, message));
                    break;
                case TalkLevel.Whisper: 
                    player.Send(new ShoutMessage(EntityId, message));
                    break;
                case TalkLevel.Shout:
                    player.Send(new ShoutMessage(EntityId, message));
                    break;
            }
            
        }
    }
}