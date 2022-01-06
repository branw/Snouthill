namespace Snouthill.Db.Models;

public class FriendRequestModel
{
    public string ReceiverName;
    public string SenderName { get; set; }
    public PlayerModel Sender { get; set; }
    public PlayerModel Receiver { get; set; }
}