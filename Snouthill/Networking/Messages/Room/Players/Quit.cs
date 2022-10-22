namespace Snouthill.Networking.Messages.Room.Players;

[Opcode(53)] // "QUIT"
public record Quit : IInboundMessage<Quit>
{
    public static Quit Deserialize(PacketReader reader) => new();
    
    public void Handle(Client client)
    {
        if (client.Player == null) throw new PlayerNotAuthenticatedException();
        if (client.Player.Room == null) throw new PlayerNotInRoomException();

        client.Player.Room.RemoveEntity(client.Player);
    }
}