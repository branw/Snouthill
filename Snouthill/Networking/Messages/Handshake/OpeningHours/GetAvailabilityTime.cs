namespace Snouthill.Networking.Messages.Handshake.OpeningHours;

[Opcode(212)] // "GET_AVAILABILITY_TIME" hh_entry/Opening Hours Handler
public record GetAvailabilityTime : IInboundMessage<GetAvailabilityTime>
{
    public static GetAvailabilityTime Deserialize(PacketReader message) => new();
}