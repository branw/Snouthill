namespace Snouthill.Networking.Messages.Room;

[Opcode(59)] // "GOTOFLAT"
public record GoToRoom(
    string RoomId) : IInboundMessage<GoToRoom>
{
    public static GoToRoom Deserialize(PacketReader reader)
    {
        var roomId = reader.ReadRawString();

        return new GoToRoom(roomId);
    }

    public void Handle(Client client)
    {
        if (client.Player == null) throw new PlayerNotAuthenticatedException();

        var id = int.Parse(RoomId);
        var room = client.Server.Rooms.GetRoom(id);

        room?.AddEntity(client.Player);
    }
}