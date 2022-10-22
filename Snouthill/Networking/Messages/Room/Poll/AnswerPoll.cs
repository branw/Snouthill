namespace Snouthill.Networking.Messages.Room.Poll;

[Opcode(236)] // "POLL_ANSWER"
public record AnswerPoll : IInboundMessage<AnswerPoll>
{
    public static AnswerPoll Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}