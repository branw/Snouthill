using Snouthill.Db.Models;

namespace Snouthill.Net.Packets.Account.Purse;

public record CreditBalance(
    string Balance) : IResponse
{
    public CreditBalance(PlayerModel playerModel) : this($"{playerModel.Credits:0.0}")
    {
    }

    public short Opcode => 6;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteString(Balance);
    }
}