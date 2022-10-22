namespace Snouthill.Networking.Messages;

[Opcode(249)] // "SET_TUTORIAL_MODE"
public record SetTutorialMode() : IInboundMessage<SetTutorialMode>
{
    public static SetTutorialMode Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}