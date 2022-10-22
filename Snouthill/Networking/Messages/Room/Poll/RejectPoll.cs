namespace Snouthill.Networking.Messages.Room.Poll;

[Opcode(235)] // "POLL_REJECT"
public record RejectPoll : IInboundMessage<RejectPoll>
{
    public static RejectPoll Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}