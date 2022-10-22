namespace Snouthill.Networking.Messages.Login;

[Opcode(3)] // hh_club/Club Handler/handle_ok
public record LoginSuccessful : IOutboundMessage;