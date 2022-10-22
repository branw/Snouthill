using Snouthill.Game;

namespace Snouthill.Networking.Messages.Room;

[Opcode(62)] // "G_OBJS"
public record GetObjects : IInboundMessage<GetObjects>
{
    public static GetObjects Deserialize(PacketReader reader) => new();

    public void Handle(Client client)
    {
        if (client.Player == null) throw new PlayerNotAuthenticatedException();
        if (client.Player.Room == null) throw new PlayerNotInRoomException();

        client.Send(new ObjectsWorld(new List<Item>()));
        client.Send(new ActiveObjects(new List<Item>()));

        client.Player.Messenger.UpdateStatus();
    }
}