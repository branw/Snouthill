namespace Snouthill.Networking.Messages.Games;

[Opcode(159)] // "GETINSTANCELIST"
public record GetInstanceList : IInboundMessage<GetInstanceList>
{
    public static GetInstanceList Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}