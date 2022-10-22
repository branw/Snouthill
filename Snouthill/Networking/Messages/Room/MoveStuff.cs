namespace Snouthill.Networking.Messages.Room;

[Opcode(73)] // "MOVESTUFF"
public record MoveStuff : IInboundMessage<MoveStuff>
{
    public static MoveStuff Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}