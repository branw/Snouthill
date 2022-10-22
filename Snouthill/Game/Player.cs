using Snouthill.Database;
using Snouthill.Database.Models;
using Snouthill.Networking;
using Snouthill.Networking.Messages;

namespace Snouthill.Game;

public class Player : AEntity
{
    private readonly Client _client;

    public string Name { get; }

    public Messenger Messenger { get; }
    public Inventory Inventory { get; }
    public override Room? Room { get; internal set; }

    public bool IsTyping { get; set; } = false;

    public PlayerModel Model { get; internal set; }

    private Player(PlayerModel model, Client client)
    {
        _client = client;

        Model = model;
        Name = model.Name;

        Messenger = new Messenger(this);
        Inventory = new Inventory();
    }
    
    public static Player? Login(Client client, string name, string password)
    {
        PlayerModel? playerModel;
        using (var db = new DatabaseContext())
        {
            playerModel = db.Players.FirstOrDefault(p => p.Name == name);
            if (playerModel == null || playerModel.Password != password) return null;
        }

        return new Player(playerModel, client);
    }
    
    public void Send(IOutboundMessage message)
    {
        _client.Send(message);
    }
}