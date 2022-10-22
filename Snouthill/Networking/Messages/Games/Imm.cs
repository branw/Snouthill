namespace Snouthill.Networking.Messages.Games;

[Opcode(117)] // "IMM"
public record Imm : IInboundMessage<Imm>
{
    public static Imm Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}