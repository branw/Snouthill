namespace Snouthill.Networking.Messages.Room;

[Opcode(230)] // v10~13+ "GET_GROUP_BADGES"
public record GetGroupBadges : IInboundMessage<GetGroupBadges>
{
    public static GetGroupBadges Deserialize(PacketReader reader) => new();
}