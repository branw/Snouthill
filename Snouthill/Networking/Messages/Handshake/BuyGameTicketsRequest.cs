namespace Snouthill.Networking.Messages.Inbound;

[Opcode(105)] // "BTCKS"
public record BuyGameTicketsRequest(
    int Amount,
    string Recipient) : IInboundMessage<BuyGameTicketsRequest>
{
    public static BuyGameTicketsRequest Deserialize(PacketReader reader)
    {
        var amount = reader.ReadInt();
        var recipient = reader.ReadString();

        return new BuyGameTicketsRequest(amount, recipient);
    }
}