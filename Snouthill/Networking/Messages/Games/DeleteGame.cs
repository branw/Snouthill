namespace Snouthill.Networking.Messages.Games;

[Opcode(164)] // "DELETEGAME"
public record DeleteGame : IInboundMessage<DeleteGame>
{
    public static DeleteGame Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}