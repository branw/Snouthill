namespace Snouthill.Networking.Messages.Games;

[Opcode(173)] // REQUESTFULLSTATUSUPDATE
public record RequestFullStatusUpdate : IInboundMessage<RequestFullStatusUpdate>
{
    public static RequestFullStatusUpdate Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}