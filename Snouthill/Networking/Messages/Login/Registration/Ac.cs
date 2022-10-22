namespace Snouthill.Networking.Messages.Login.Registration;

[Opcode(46)] // "AC"
public record Ac : IInboundMessage<Ac>
{
    public static Ac Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}