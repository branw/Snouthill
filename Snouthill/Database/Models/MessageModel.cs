using System.ComponentModel.DataAnnotations;

namespace Snouthill.Database.Models;

public class MessageModel
{
    [Key] public int Id { get; set; }

    public string SenderName { get; set; } = null!;
    public PlayerModel Sender { get; set; } = null!;

    public string ReceiverName { get; set; } = null!;
    public PlayerModel Receiver { get; set; } = null!;

    public string Body { get; set; } = null!;

    public int Date { get; set; }

    public bool Read { get; set; } = false;
}