namespace Snouthill.Networking.Messages.Messenger;

[Opcode(12)] // "MESSENGERINIT"
public record InitMessenger : IInboundMessage<InitMessenger>
{
    public static InitMessenger Deserialize(PacketReader reader) => new();

    public void Handle(Client client)
    {
        if (client.Player == null)
            throw new PlayerNotAuthenticatedException();
        
        client.Send(new InitMessengerResponse(
            "Hello",
            10,
            5,
            8,
            new List<FriendInfo>
            {
                new(
                    0, "Foo",
                    true,
                    "Motto",
                    false,
                    "Current Location",
                    "Last Online",
                    client.Player.Model.Figure)
            }));

        
    }
}