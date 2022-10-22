namespace Snouthill.Networking.Messages.Games;

[Opcode(114)] // "PTM"
public record Ptm : IInboundMessage<Ptm>
{
    public static Ptm Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}