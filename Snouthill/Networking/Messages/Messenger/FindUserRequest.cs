namespace Snouthill.Networking.Messages.Messenger;

[Opcode(41)] // "FINDUSER"
public record FindUserRequest(
    string Query) : IInboundMessage<FindUserRequest>
{
    public static FindUserRequest Deserialize(PacketReader reader)
    {
        var query = reader.ReadString();

        return new FindUserRequest(query);
    }
}