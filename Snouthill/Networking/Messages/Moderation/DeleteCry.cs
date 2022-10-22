namespace Snouthill.Networking.Messages.Moderation;

[Opcode(273)] // [[#hobba_handler, #handle_delete_cry]]
public record DeleteCry : IOutboundMessage;