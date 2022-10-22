namespace Snouthill.Networking.Messages.Messenger;

// hh_messenger/Messenger Interface
[Opcode(30)] // "MESSENGER_C_CLICK"
public record MessengerCClick : IInboundMessage<MessengerCClick>
{
    public static MessengerCClick Deserialize(PacketReader reader) => new();
}