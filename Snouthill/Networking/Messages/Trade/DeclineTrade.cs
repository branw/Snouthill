namespace Snouthill.Networking.Messages.Trade;

[Opcode(68)] // "TRADE_UNACCEPT"
public record DeclineTrade : IInboundMessage<DeclineTrade>
{
    public static DeclineTrade Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}