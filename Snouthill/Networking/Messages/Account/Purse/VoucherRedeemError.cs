namespace Snouthill.Networking.Messages.Account.Purse;

[Opcode(213)] // hh_purse::handle_purse
public record VoucherRedeemError(
    VoucherRedeemError.ErrorType Error) : IOutboundMessage
{
    // purse_vouchers_error
    public enum ErrorType
    {
        TechnicalError = 0, // "Technical error! Cannot redeem voucher."
        Invalid = 1, // "Invalid voucher code."
        ProductDeliveryFailed = 2, // "Product delivery failed, please contact Customer Service"
        WebOnly = 3, // "This voucher must be redeemed on the Habbo website"
    }

    public void Serialize(PacketWriter message)
    {
        message.WriteRawString(((int) Error).ToString());
    }
}