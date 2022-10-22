using Snouthill.Networking.Messages.Account;

namespace Snouthill.Networking.Messages.Room;

[Opcode(64)] // "G_STAT"
public record GetStat : IInboundMessage<GetStat>
{
    public static GetStat Deserialize(PacketReader reader) => new();

    public void Handle(Client client)
    {
        if (client.Player == null) throw new PlayerNotAuthenticatedException();
        if (client.Player.Room == null) throw new PlayerNotInRoomException();

        var room = client.Player.Room;
        
        room.Send(new UserObjects(room.Entities), client.Player);
        client.Send(new UserObject(client.Player));
    }
}