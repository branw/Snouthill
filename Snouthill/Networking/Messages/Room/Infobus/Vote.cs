namespace Snouthill.Networking.Messages.Room.Infobus;

[Opcode(112)] // "VOTE"
public record Vote : IInboundMessage<Vote>
{
    public static Vote Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}