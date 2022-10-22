namespace Snouthill.Networking.Messages.Games;

[Opcode(161)] // "UNOBSERVEINSTANCE"
public record UnobserveInstance : IInboundMessage<UnobserveInstance>
{
    public static UnobserveInstance Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}