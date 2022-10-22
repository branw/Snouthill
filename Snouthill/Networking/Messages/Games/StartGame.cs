namespace Snouthill.Networking.Messages.Games;

[Opcode(170)] // "STARTGAME"
public record StartGame : IInboundMessage<StartGame>
{
    public static StartGame Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}