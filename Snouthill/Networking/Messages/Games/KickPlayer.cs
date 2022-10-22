namespace Snouthill.Networking.Messages.Games;

[Opcode(168)] // "KICKPLAYER"
public record KickPlayer : IInboundMessage<KickPlayer>
{
    public static KickPlayer Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}