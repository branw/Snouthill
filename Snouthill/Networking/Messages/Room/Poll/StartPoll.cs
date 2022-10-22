namespace Snouthill.Networking.Messages.Room.Poll;

[Opcode(234)] // "POLL_START"
public record StartPoll : IInboundMessage<StartPoll>
{
    public static StartPoll Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}