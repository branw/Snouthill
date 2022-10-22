namespace Snouthill.Networking.Messages.Games;

[Opcode(166)] // "JOINPARAMETERVALUES"
public record JoinParameterValues : IInboundMessage<JoinParameterValues>
{
    public static JoinParameterValues Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}