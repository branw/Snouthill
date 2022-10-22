namespace Snouthill.Networking.Messages.Messenger;

[Opcode(36)] // "MESSENGER_ASSIGNPERSMSG"
public record AssignPersistentMessage(
    string PersistentMessage) : IInboundMessage<AssignPersistentMessage>
{
    public static AssignPersistentMessage Deserialize(PacketReader reader)
    {
        var persistentMessage = reader.ReadString();

        return new AssignPersistentMessage(persistentMessage);
    }
}