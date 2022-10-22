namespace Snouthill.Networking.Messages.Room;

[Opcode(115)] // "GOAWAY"
public record GoAway() : IInboundMessage<GoAway>
{
    public static GoAway Deserialize(PacketReader reader) => new();
}