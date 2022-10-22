namespace Snouthill.Networking.Messages;

[AttributeUsage(AttributeTargets.Class)]
public class OpcodeAttribute : Attribute
{
    public OpcodeAttribute(short opcode)
    {
        Opcode = opcode;
    }

    public short Opcode { get; }
}