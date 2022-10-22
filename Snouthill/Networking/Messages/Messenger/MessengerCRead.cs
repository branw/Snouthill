namespace Snouthill.Networking.Messages.Messenger;

// hh_messenger/Messenger Component
// hh_messenger/Messenger Interface
[Opcode(31)] // "MESSENGER_C_READ"
public record MessengerCRead : IInboundMessage<MessengerCRead>
{
    public static MessengerCRead Deserialize(PacketReader reader) => new();
}