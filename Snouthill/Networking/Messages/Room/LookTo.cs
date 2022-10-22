namespace Snouthill.Networking.Messages.Room;

[Opcode(79)] // "LOOKTO"
public record LookTo(
    int X,
    int Y) : IInboundMessage<LookTo>
{
    public static LookTo Deserialize(PacketReader message)
    {
        var position = message.ReadRawString().Split(' ');
        var x = int.Parse(position[0]);
        var y = int.Parse(position[1]);

        return new LookTo(x, y);
    }

    public void Handle(Client client)
    {
        if (client.Player == null)
            throw new PlayerNotAuthenticatedException();
        if (client.Player.Room == null)
            throw new PlayerNotInRoomException();
        
        //TODO

        client.Player.Dirty = true;
    }
}