namespace Snouthill.Net.Packets.Messenger;

[RequestOpcode(36)]
public record AssignPersistentMessageRequest(
    string PersistentMessage) : IRequest;

public class AssignPersistentMessageRequestDeserializer : IRequestDeserializer<AssignPersistentMessageRequest>
{
    public AssignPersistentMessageRequest Deserialize(PacketReader reader)
    {
        var persistentMessage = reader.ReadString();

        return new AssignPersistentMessageRequest(persistentMessage);
    }
}