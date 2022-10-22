namespace Snouthill.Networking.Messages;

[Opcode(250)] // GET_TUTORIAL_CONFIGURATION
public record GetTutorialConfig : IInboundMessage<GetTutorialConfig>
{
    public static GetTutorialConfig Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}