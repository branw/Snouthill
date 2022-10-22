namespace Snouthill.Networking.Messages.Room.Players;

[Opcode(18)] // [[#room_handler, #handle_clc]]
public record HotelView : IOutboundMessage;