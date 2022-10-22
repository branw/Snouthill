namespace Snouthill.Networking.Messages.Room.Furni;

[Opcode(77)] // "DICE_OFF"
public record CloseDice : IInboundMessage<CloseDice>
{
    public static CloseDice Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}