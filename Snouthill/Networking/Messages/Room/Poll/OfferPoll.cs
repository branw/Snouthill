namespace Snouthill.Networking.Messages.Room.Poll;

[Opcode(316)] // hh_poll/Poll Handler/handle_poll_offer
public record OfferPoll : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        throw new NotImplementedException();
    }
}