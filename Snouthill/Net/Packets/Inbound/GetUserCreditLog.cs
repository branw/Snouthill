namespace Snouthill.Net.Packets.Inbound;

[RequestOpcode(127)]
public record GetUserCreditLog : IRequest;