namespace Snouthill.Networking.Messages.Room;

[Opcode(81)] // "INTODOOR"
public record IntoDoor : IInboundMessage<IntoDoor>
{
    public static IntoDoor Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}