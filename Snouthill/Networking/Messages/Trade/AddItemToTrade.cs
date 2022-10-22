namespace Snouthill.Networking.Messages.Trade;

[Opcode(72)] // "TRADE_ADDITEM"
public record AddItemToTrade : IInboundMessage<AddItemToTrade>
{
    public static AddItemToTrade Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}