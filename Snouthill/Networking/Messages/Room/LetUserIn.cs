namespace Snouthill.Networking.Messages.Room;

[Opcode(98)] // "LETUSERIN"
public record LetUserIn : IInboundMessage<LetUserIn>
{
    public static LetUserIn Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}