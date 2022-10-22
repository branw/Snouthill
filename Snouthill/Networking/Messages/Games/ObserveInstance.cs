namespace Snouthill.Networking.Messages.Games;

[Opcode(160)] // "OBSERVEINSTANCE"
public record ObserveInstance : IInboundMessage<ObserveInstance>
{
    public static ObserveInstance Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}