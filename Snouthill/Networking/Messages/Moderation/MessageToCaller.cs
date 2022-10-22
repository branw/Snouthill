namespace Snouthill.Networking.Messages.Moderation;

[Opcode(199)] // "MESSAGETOCALLER"
public record MessageToCaller : IInboundMessage<MessageToCaller>
{
    public static MessageToCaller Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}