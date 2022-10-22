namespace Snouthill.Networking.Messages.Games;

[Opcode(171)] // "GAMEEVENT"
public record GameEvent : IInboundMessage<GameEvent>
{
    public static GameEvent Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}