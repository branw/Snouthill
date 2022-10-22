namespace Snouthill.Networking.Messages.Room.Poll;

[Opcode(318)] // hh_poll/Poll Handler/handle_poll_error
public record PollError : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        throw new NotImplementedException();
    }
}