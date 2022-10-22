namespace Snouthill.Networking.Messages.Navigator;

[Opcode(156)] // "GETPARENTCHAIN"
public record GetParentChain : IInboundMessage<GetParentChain>
{
    public static GetParentChain Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}