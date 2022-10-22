namespace Snouthill.Networking.Messages.Login.Registration;

[Opcode(131)] // "COPPA_REG_GETREALTIME"
public record GetRealTime : IInboundMessage<GetRealTime>
{
    public static GetRealTime Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}