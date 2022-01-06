using System.ComponentModel.DataAnnotations;

namespace Snouthill.Db.Models;

public class MessageModel
{
    [Key] public int Id { get; set; }

    public string SenderName { get; set; }
    public PlayerModel Sender { get; set; }

    public string ReceiverName { get; set; }
    public PlayerModel Receiver { get; set; }

    public string Body { get; set; }

    public int Date { get; set; }

    public bool Read { get; set; } = false;
}