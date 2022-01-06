namespace Snouthill.Net.Packets;

public class RequestOpcodeAttribute : Attribute
{
    public RequestOpcodeAttribute(short opcode)
    {
        Opcode = opcode;
    }

    public short Opcode { get; init; }
}