namespace Snouthill.Networking.Messages.Room;

[Opcode(216)] // "GET_SPECTATOR_AMOUNT"
public record GetSpectatorAmount : IInboundMessage<GetSpectatorAmount>
{
    public static GetSpectatorAmount Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}