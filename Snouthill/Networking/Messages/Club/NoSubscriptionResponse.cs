namespace Snouthill.Networking.Messages.Club;

// [Opcode("SCR_NOSUB", 5)] // v5 hh_club/Club Handler/handle_scr_nosub
[Opcode(22)]
public record NoSubscriptionResponse : IOutboundMessage;