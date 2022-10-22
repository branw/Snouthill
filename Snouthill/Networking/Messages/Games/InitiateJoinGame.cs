namespace Snouthill.Networking.Messages.Games;

[Opcode(165)]
public record InitiateJoinGame : IInboundMessage<InitiateJoinGame>
{
    public static InitiateJoinGame Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}