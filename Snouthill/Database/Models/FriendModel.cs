namespace Snouthill.Database.Models;

public class FriendModel
{
    public int SenderPlayerId { get; set; }
    public int ReceiverPlayerId { get; set; }
    public PlayerModel Sender { get; set; } = null!;
    public PlayerModel Receiver { get; set; } = null!;
}