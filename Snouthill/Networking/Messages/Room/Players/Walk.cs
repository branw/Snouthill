namespace Snouthill.Networking.Messages.Room.Players;

[Opcode(75)] // "MOVE"
public record Walk(
    int X,
    int Y) : IInboundMessage<Walk>
{
    public static Walk Deserialize(PacketReader message)
    {
        var x = message.ReadBase64Short();
        var y = message.ReadBase64Short();

        return new Walk(x, y);
    }

    public void Handle(Client client)
    {
        if (client.Player == null)
            throw new PlayerNotAuthenticatedException();
        if (client.Player.Room == null)
            throw new PlayerNotInRoomException();

        client.Player.WalkTo(X, Y);
    }
}