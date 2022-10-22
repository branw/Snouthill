namespace Snouthill.Networking.Messages.Inbound;

[Opcode(247)] // v14+ "SPIN_WHEEL_OF_FORTUNE"
public record SpinWheelOfFortune(
    int PlayerId) : IInboundMessage<SpinWheelOfFortune>
{
    public static SpinWheelOfFortune Deserialize(PacketReader reader)
    {
        throw new NotImplementedException();
    }
}