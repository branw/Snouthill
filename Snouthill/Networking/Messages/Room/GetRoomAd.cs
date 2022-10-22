namespace Snouthill.Networking.Messages.Room;

[Opcode(126)] // "GETROOMAD"
public record GetRoomAd : IInboundMessage<GetRoomAd>
{
    public static GetRoomAd Deserialize(PacketReader reader) => new();

    public void Handle(Client client)
    {
        if (client.Player == null) throw new PlayerNotAuthenticatedException();

        client.Send(new RoomAd());
    }
}