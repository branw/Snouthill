using Snouthill.Game;

namespace Snouthill.Net.Packets.Account.Purse;

[RequestOpcode(129)] // "REDEEM_VOUCHER"
public record RedeemVoucher(
    string Code) : IRequest;

public class RedeemVoucherDeserializer : IRequestDeserializer<RedeemVoucher>
{
    public RedeemVoucher Deserialize(PacketReader reader)
    {
        var code = reader.ReadString();

        return new RedeemVoucher(code);
    }
}

public class RedeemVoucherHandler : IRequestHandler<RedeemVoucher>
{
    public void Handle(RedeemVoucher request, Player player)
    {
        if (request.Code.Equals("bazinga"))
        {
            player.Send(new VoucherRedeemSuccess(new List<(string Name, string Description)>
            {
                ("Item 1", "Desc"),
                ("Item 2", "Bar"),
                ("Item 3", "Baz")
            }));

            player.Send(new CreditBalance("100.0"));
        }
        else
        {
            player.Send(new VoucherRedeemError(VoucherRedeemError.ErrorType.Invalid));
        }
    }
}