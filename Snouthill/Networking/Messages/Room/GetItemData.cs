namespace Snouthill.Networking.Messages.Room;

[Opcode(83)] // "G_IDATA"
public record GetItemData : IInboundMessage<GetItemData>
{
    public static GetItemData Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}