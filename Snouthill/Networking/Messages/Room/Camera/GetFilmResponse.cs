namespace Snouthill.Networking.Messages.Outbound;

[Opcode(4)] // [[#photo_handler, #handle_film]]
public record GetFilmResponse : IOutboundMessage;