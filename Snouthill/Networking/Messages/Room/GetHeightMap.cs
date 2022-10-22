namespace Snouthill.Networking.Messages.Room;

[Opcode(60)] // "G_HMAP"
public record GetHeightMap : IInboundMessage<GetHeightMap>
{
    public static GetHeightMap Deserialize(PacketReader reader) => new();

    public void Handle(Client client)
    {
        if (client.Player == null) throw new PlayerNotAuthenticatedException();
        if (client.Player.Room == null) throw new PlayerNotInRoomException();

        client.Send(new HeightMap(client.Player.Room.Layout.HeightMap));
    }
}