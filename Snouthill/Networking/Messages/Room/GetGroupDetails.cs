namespace Snouthill.Networking.Messages.Room;

[Opcode(231)] // "GET_GROUP_DETAILS"
public record GetGroupDetails : IInboundMessage<GetGroupDetails>
{
    public static GetGroupDetails Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}