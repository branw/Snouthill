using Snouthill.Game;

namespace Snouthill.Net.Packets.Catalog;

[RequestOpcode(100)] // "GRPC"
public record BuyItemRequest(
    string PageName,
    string SaleCode,
    string ExtraData,
    bool IsGift,
    string? GiftRecipient,
    string? GiftMessage) : IRequest;

public class BuyItemRequestDeserializer : IRequestDeserializer<BuyItemRequest>
{
    public BuyItemRequest Deserialize(PacketReader reader)
    {
        var data = reader.ReadRawString().Split("\r");

        var stage = data[0]; // "production"
        var pageName = data[1]; // "Gothic"
        var language = data[2]; // "en"
        var saleCode = data[3]; // "gothic_chair*3"
        var extraData = data[4]; // "-"

        var isGift = data[5] == "1";
        var giftRecipient = isGift ? data[6] : null;
        var giftMessage = isGift ? data[7] : null;

        return new BuyItemRequest(pageName, saleCode, extraData, isGift, giftRecipient, giftMessage);
    }
}

public class BuyItemRequestHandler : IRequestHandler<BuyItemRequest>
{
    public void Handle(BuyItemRequest request, Player player)
    {
        player.Send(new NoCreditsResponse());
    }
}