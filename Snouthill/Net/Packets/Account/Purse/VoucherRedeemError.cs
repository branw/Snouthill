namespace Snouthill.Net.Packets.Account.Purse;

public record VoucherRedeemError(
    VoucherRedeemError.ErrorType Error) : IResponse
{
    public enum ErrorType
    {
        TechnicalError = 0, // "Technical error! Cannot redeem voucher."
        Invalid = 1, // "Invalid voucher code."
        ProductDeliveryFailed = 2, // "Product delivery failed, please contact Customer Service"
        WebOnly = 3 // "This voucher must be redeemed on the Habbo website"
    }

    public short Opcode => 213;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteRawString(((int) Error).ToString());
    }
}