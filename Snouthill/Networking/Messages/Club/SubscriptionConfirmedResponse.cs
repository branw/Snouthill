namespace Snouthill.Networking.Messages.Club;

// [Opcode("SCR_SOK")] // hh_club/Club Handler/handle_scr_sok
[Opcode(23)]
public record SubscriptionConfirmedResponse : IOutboundMessage;