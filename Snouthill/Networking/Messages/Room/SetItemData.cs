namespace Snouthill.Networking.Messages.Room;

[Opcode(84)] // "SETITEMDATA"
public record SetItemData : IInboundMessage<SetItemData>
{
    public static SetItemData Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}