namespace Snouthill.Networking.Messages.Handshake;

[Opcode(0)]
public record Hello : IOutboundMessage;