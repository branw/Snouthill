namespace Snouthill.Networking.Messages.Room;

[Opcode(61)] // "G_USRS"
public record GetUsers : IInboundMessage<GetUsers>
{
    public static GetUsers Deserialize(PacketReader reader) => new();

    public void Handle(Client client)
    {
        if (client.Player == null) throw new PlayerNotAuthenticatedException();
        if (client.Player.Room == null) throw new PlayerNotInRoomException();

        client.Player.Send(new UserObjects(client.Player.Room.Entities));
    }
}