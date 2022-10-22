namespace Snouthill.Networking.Messages.Room.Furni;

[Opcode(76)] // "THROW_DICE"
public record ThrowDice : IInboundMessage<ThrowDice>
{
    public static ThrowDice Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}