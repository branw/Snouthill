namespace Snouthill.Networking.Messages.Login;

[Opcode(50)] // [[#login_handler, #handlePing]]
public record Ping : IOutboundMessage;