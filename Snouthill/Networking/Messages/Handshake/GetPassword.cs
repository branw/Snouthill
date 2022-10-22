namespace Snouthill.Networking.Messages.Handshake;

[Opcode(47)] // "GET_PASSWORD"
public record GetPassword : IInboundMessage<GetPassword>
{
    public static GetPassword Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}