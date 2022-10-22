namespace Snouthill.Networking.Messages.Room;

[Opcode(99)] // "REMOVESTUFF"
public record RemoveStuff : IInboundMessage<RemoveStuff>
{
    public static RemoveStuff Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}