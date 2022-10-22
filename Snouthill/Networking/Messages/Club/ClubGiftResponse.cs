namespace Snouthill.Networking.Messages.Club;

[Opcode(280)] // [[#habbo_club_handler, #handle_gift]]
public record ClubGiftResponse : IOutboundMessage;