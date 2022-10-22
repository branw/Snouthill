namespace Snouthill.Networking.Messages.Navigator;

[Opcode(21)] // "GETFLATINFO"
public record GetRoomInfo : IInboundMessage<GetRoomInfo>
{
    public static GetRoomInfo Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}