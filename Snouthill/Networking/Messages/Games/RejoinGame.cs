namespace Snouthill.Networking.Messages.Games;

[Opcode(172)] // "REJOINGAME"
public record RejoinGame : IInboundMessage<RejoinGame>
{
    public static RejoinGame Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}