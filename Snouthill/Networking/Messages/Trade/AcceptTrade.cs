namespace Snouthill.Networking.Messages.Trade;

[Opcode(69)] // "TRADE_ACCEPT"
public record AcceptTrade : IInboundMessage<AcceptTrade>
{
    public static AcceptTrade Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}