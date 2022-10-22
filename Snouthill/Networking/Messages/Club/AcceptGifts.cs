namespace Snouthill.Networking.Messages.Club;

[Opcode(210)] // SCR_GIFT_APPROVAL
public record AcceptGifts(
    int NumGiftsAccepted) : IInboundMessage<AcceptGifts>
{
    public static AcceptGifts Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}