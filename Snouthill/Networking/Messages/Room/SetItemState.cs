namespace Snouthill.Networking.Messages.Room;

[Opcode(214)] // "SETITEMSTATE"
public record SetItemState : IInboundMessage<SetItemState>
{
    public static SetItemState Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}