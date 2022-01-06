namespace Snouthill.Net.Packets.Outbound;

public record OpenConnection : IResponse
{
    public short Opcode => 19;
}