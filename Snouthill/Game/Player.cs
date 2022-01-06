using Snouthill.Net;
using Snouthill.Net.Packets;

namespace Snouthill.Game;

public class Player : AEntity
{
    private readonly GameClient _client;

    public Player(GameClient client)
    {
        _client = client;
    }

    public string? Name { get; set; }

    public override Room? Room { get; set; }

    public Messenger? Messenger { get; set; }

    public Inventory? Inventory { get; set; }

    public bool IsTyping { get; set; } = false;

    public void Send(IResponse packet)
    {
        _client.Send(packet);
    }

    public void Wave()
    {
    }

    public new void Talk(TalkLevel level, string message, IEnumerable<string>? recipientNames = null)
    {
        if (message.EndsWith("/o"))
        {
            Wave();

            if (message.Equals("/o")) return;
        }

        base.Talk(level, message);
    }
}