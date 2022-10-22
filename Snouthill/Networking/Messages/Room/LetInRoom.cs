namespace Snouthill.Networking.Messages.Room;

[Opcode(41)] // [[#room_handler, #handle_flat_letin]]
public record LetInRoom : IOutboundMessage;