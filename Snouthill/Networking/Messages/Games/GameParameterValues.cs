namespace Snouthill.Networking.Messages.Games;

[Opcode(163)] // "GAMEPARAMETERVALUES"
public record GameParameterValues : IInboundMessage<GameParameterValues>
{
    public static GameParameterValues Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}