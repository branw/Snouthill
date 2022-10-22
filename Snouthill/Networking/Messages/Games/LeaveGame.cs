namespace Snouthill.Networking.Messages.Games;

[Opcode(167)] // "LEAVEGAME"
public record LeaveGame : IInboundMessage<LeaveGame>
{
    public static LeaveGame Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}