namespace Snouthill.Networking.Messages.Room.Players;

[Opcode(94)] // "WAVE"
public record Wave : IInboundMessage<Wave>
{
    public static Wave Deserialize(PacketReader reader) => new();
}