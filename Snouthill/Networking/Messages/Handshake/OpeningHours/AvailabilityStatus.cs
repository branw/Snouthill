namespace Snouthill.Networking.Messages.Handshake.OpeningHours;

[Opcode(290)] // hh_entry/Opening Hours Handler/handleAvailabilityStatus
public record AvailabilityStatus(
    bool IsOpen,
    bool ShutDown) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        throw new NotImplementedException();
    }
}