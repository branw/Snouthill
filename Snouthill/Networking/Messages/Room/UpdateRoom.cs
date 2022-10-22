namespace Snouthill.Networking.Messages.Room;

[Opcode(24)] // "UPDATEFLAT"
public record UpdateRoom : IInboundMessage<UpdateRoom>
{
    public static UpdateRoom Deserialize(PacketReader reader) => new();
}