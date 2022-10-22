namespace Snouthill.Networking.Messages.Games;

[Opcode(169)] // "WATCHTGAME"
public record WatchGame : IInboundMessage<WatchGame>
{
    public static WatchGame Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}