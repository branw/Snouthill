namespace Snouthill.Networking.Messages;

[Opcode(252)] // "GET_TUTORIAL_STATUS"
public record GetTutorialStatus : IInboundMessage<GetTutorialStatus>
{
    public static GetTutorialStatus Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}