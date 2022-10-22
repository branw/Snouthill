namespace Snouthill.Networking.Messages.Moderation;

// [Opcode("CRYFORHELP", 5)] // v5 hh_navigator/Hobba Handler/handle_cryforhelp
[Opcode(148)] // v7 hh_shared/Hobba Handler/handle_cryforhelp
public record CryForHelpResponse : IOutboundMessage;