namespace Snouthill.Networking.Messages.Account.Purse;

[Opcode(129)] // "REDEEM_VOUCHER"
public record RedeemVoucher(
    string Code) : IInboundMessage<RedeemVoucher>
{
    public static RedeemVoucher Deserialize(PacketReader reader)
    {
        var code = reader.ReadString();

        return new RedeemVoucher(code);
    }

    public void Handle(Client client)
    {
        if (Code.Equals("bazinga"))
        {
            client.Send(new VoucherRedeemSuccess(new List<(string Name, string Description)>
            {
                ("Item 1", "Desc"),
                ("Item 2", "Bar"),
                ("Item 3", "Baz")
            }));

            client.Send(new CreditBalance("100.0"));
        }
        else
        {
            client.Send(new VoucherRedeemError(VoucherRedeemError.ErrorType.Invalid));
        }
    }
}