namespace Snouthill.Networking.Messages.Handshake.OpeningHours;

[Opcode(292)] // hh_entry/Opening Hours Handler/handleInfoHotelClosed
public record HotelClosed(
    int OpeningHour,
    int OpeningMinute,
    bool Disconnect) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        throw new NotImplementedException();
    }
}