namespace Snouthill.Networking.Messages.Room;

[Opcode(54)] // "GOVIADOOR"
public record GoViaDoor : IInboundMessage<GoViaDoor>
{
    public static GoViaDoor Deserialize(PacketReader reader) => new();
}