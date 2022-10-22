namespace Snouthill.Networking.Messages;

[Opcode(253)] // "COMPLETE_TUTORIAL_TOPIC"
public record CompleteTutorialTopic : IInboundMessage<CompleteTutorialTopic>
{
    public static CompleteTutorialTopic Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}