namespace Snouthill.Networking.Messages.Room;

[Opcode(23)] // "DELETEFLAT"
public record DeleteRoom : IInboundMessage<DeleteRoom>
{
    public static DeleteRoom Deserialize(PacketReader reader) => new();
}