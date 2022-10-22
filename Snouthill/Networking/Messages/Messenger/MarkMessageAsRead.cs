namespace Snouthill.Networking.Messages.Messenger;

// v1 MessengerScript/Message
// v7 hh_messenger/Messenger Component
[Opcode(32)] // "MESSENGER_MARKREAD"
public record MarkMessageAsRead : IInboundMessage<MarkMessageAsRead>
{
    public static MarkMessageAsRead Deserialize(PacketReader reader) => new();
}