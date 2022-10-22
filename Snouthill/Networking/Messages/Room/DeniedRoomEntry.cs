namespace Snouthill.Networking.Messages.Room;

[Opcode(131)] // [[#room_handler, #handle_flatnotallowedtoenter]]
public record DeniedRoomEntry : IOutboundMessage;