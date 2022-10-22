namespace Snouthill.Networking.Messages.Room.Players;

[Opcode(93)] // "DANCE"
public record Dance : IInboundMessage<Dance>
{
    public static Dance Deserialize(PacketReader reader) => new();
}