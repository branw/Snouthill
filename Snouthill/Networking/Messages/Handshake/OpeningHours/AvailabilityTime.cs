namespace Snouthill.Networking.Messages.Handshake.OpeningHours;

[Opcode(293)] // hh_entry/Opening Hours Handler/handleAvailabilityTime
public record AvailabilityTime : IOutboundMessage;