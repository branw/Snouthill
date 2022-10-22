namespace Snouthill.Database.Models;

public class FriendRequestModel
{
    public string ReceiverName { get; set; }  = null!;
    public string SenderName { get; set; } = null!;
    public PlayerModel Sender { get; set; } = null!;
    public PlayerModel Receiver { get; set; } = null!;
}