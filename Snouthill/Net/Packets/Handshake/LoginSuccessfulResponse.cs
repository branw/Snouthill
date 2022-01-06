namespace Snouthill.Net.Packets.Handshake;

public record LoginSuccessfulResponse : IResponse
{
    public short Opcode => 3;
}