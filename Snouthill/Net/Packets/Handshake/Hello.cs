namespace Snouthill.Net.Packets.Handshake;

public record Hello : IResponse
{
    public short Opcode => 0;
}