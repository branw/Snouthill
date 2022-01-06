namespace Snouthill.Net.Packets.Registration;

public record ApproveEmailResponse : IResponse
{
    public short Opcode => 271;
}