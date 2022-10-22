namespace Snouthill.Networking.Messages.Login.Registration;

[Opcode(130)] // "COPPA_REG_CHECKTIME"
public record CheckTime : IInboundMessage<CheckTime>
{
    public static CheckTime Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}