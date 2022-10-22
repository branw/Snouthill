namespace Snouthill.Networking.Messages.Account;

[Opcode(9)] // "GETAVAILABLESETS"
public record GetAvailableSets : IInboundMessage<GetAvailableSets>
{
    public static GetAvailableSets Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}