namespace Snouthill.Networking.Messages.Trade;

[Opcode(70)] // "TRADE_CLOSE"
public record CloseTrade : IInboundMessage<CloseTrade>
{
    public static CloseTrade Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}