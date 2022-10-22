namespace Snouthill.Networking.Messages.Room;

[Opcode(57)] // "TRYFLAT"
public record TryRoom(
    int RoomId,
    string? Password) : IInboundMessage<TryRoom>
{
    public static TryRoom Deserialize(PacketReader reader)
    {
        var contents = reader.ReadRawString().Split("/");

        var roomId = int.Parse(contents[0]);
        var password = contents.Length > 1 ? contents[1] : null;

        return new TryRoom(roomId, password);
    }

    public void Handle(Client client)
    {
        if (client.Player == null) throw new PlayerNotAuthenticatedException();

        var room = client.Server.Rooms.GetRoom(RoomId);
        if (room == null) return;

        //TODO handle locked rooms

        client.Player.Send(new LetInRoom());
    }
}