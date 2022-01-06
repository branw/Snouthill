namespace Snouthill.Net.Packets.Catalog;

public record NoCreditsResponse : IResponse
{
    public short Opcode => 68;
}