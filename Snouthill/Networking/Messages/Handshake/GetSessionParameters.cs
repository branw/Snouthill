namespace Snouthill.Networking.Messages.Handshake;

[Opcode(181)] // "GET_SESSION_PARAMETERS"
public record GetSessionParameters : IInboundMessage<GetSessionParameters>
{
    public static GetSessionParameters Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}