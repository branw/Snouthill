namespace Snouthill.Networking.Messages.Room;

[Opcode(19)] // [[#room_handler, #handle_opc_ok]]
public record OpenConnection : IOutboundMessage;