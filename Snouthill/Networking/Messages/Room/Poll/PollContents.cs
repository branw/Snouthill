namespace Snouthill.Networking.Messages.Room.Poll;

[Opcode(317)] // hh_poll/Poll Handler/handle_poll_contents
public record PollContents : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        throw new NotImplementedException();
    }
}