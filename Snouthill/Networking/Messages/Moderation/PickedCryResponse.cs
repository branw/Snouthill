namespace Snouthill.Networking.Messages.Moderation;

// [Opcode("PICKED_CRY")] // v5  hh_navigator/Hobba Handler/handle_picked_cry
[Opcode(149)] // v7  hh_shared/Hobba Handler/handle_picked_cry
public record PickedCryResponse : IOutboundMessage;