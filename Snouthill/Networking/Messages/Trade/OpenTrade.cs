namespace Snouthill.Networking.Messages.Trade;

[Opcode(71)] // "TRADE_OPEN"
public record OpenTrade : IInboundMessage<OpenTrade>
{
    public static OpenTrade Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}