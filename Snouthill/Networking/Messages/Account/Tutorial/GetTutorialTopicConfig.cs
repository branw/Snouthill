namespace Snouthill.Networking.Messages;

[Opcode(251)] // "GET_TUTORIAL_TOPIC_CONFIGURATION"
public record GetTutorialTopicConfig : IInboundMessage<GetTutorialTopicConfig>
{
    public static GetTutorialTopicConfig Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}