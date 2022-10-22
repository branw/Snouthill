namespace Snouthill.Networking.Messages.Navigator;

[Opcode(154)] // "GETSPACENODEUSERS"
public record GetSpaceNodeUsers : IInboundMessage<GetSpaceNodeUsers>
{
    public static GetSpaceNodeUsers Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}