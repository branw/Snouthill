namespace Snouthill.Networking.Messages.Room.Furni;

[Opcode(78)] // "PRESENTOPEN"
public record OpenPresent : IInboundMessage<OpenPresent>
{
    public static OpenPresent Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}