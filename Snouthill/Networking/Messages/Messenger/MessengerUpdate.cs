namespace Snouthill.Networking.Messages.Messenger;

[Opcode(15)] // "MESSENGER_UPDATE"
public record MessengerUpdate : IInboundMessage<MessengerUpdate>
{
    public static MessengerUpdate Deserialize(PacketReader reader) => new();
    
    public void Handle(Client client)
    {
        client.Send(new FriendsUpdate(
            new List<FriendInfo>
            {
                new(
                    1, "Foo",
                    true,
                    "Motto",
                    false,
                    "Current Location",
                    "Last Online",
                    client.Player!.Model.Figure)
            }));
    }
}