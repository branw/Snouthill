using Snouthill.Game;

namespace Snouthill.Networking.Messages.Room;

[Opcode(63)] // "G_ITEMS"
public record GetItems : IInboundMessage<GetItems>
{
    public static GetItems Deserialize(PacketReader reader) => new();

    public void Handle(Client client)
    {
        if (client.Player == null) throw new PlayerNotAuthenticatedException();
        if (client.Player.Room == null) throw new PlayerNotInRoomException();

        client.Send(new GetItemsResponse(new List<Item>()));
    }
}