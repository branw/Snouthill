namespace Snouthill.Networking.Messages.Messenger;

[Opcode(233)] // "GET_BUDDY_REQUESTS"
public record GetFriendRequests : IInboundMessage<GetFriendRequests>
{
    public static GetFriendRequests Deserialize(PacketReader message) => new();

    public void Handle(Client client)
    {
        throw new NotImplementedException();
    }
}