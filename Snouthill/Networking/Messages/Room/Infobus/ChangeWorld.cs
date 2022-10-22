namespace Snouthill.Networking.Messages.Room.Infobus;

[Opcode(111)] // "CHANGEWORLD"
public record ChangeWorld : IInboundMessage<ChangeWorld>
{
    public static ChangeWorld Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}