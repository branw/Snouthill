namespace Snouthill.Networking.Messages.Handshake.OpeningHours;

[Opcode(294)] // hh_entry/Opening Hours Handler/handleLoginFailedHotelClosed
public record LoginFailedHotelClosed(
    int OpeningHour,
    int OpeningMinute) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        throw new NotImplementedException();
    }
}