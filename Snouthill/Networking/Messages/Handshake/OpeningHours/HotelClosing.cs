namespace Snouthill.Networking.Messages.Handshake.OpeningHours;

[Opcode(291)] // hh_entry/Opening Hours Handler/handleInfoHotelClosing
public record HotelClosing(
    int MinutesUntilClosing) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        throw new NotImplementedException();
    }
}