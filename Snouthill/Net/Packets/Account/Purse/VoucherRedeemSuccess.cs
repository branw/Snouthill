namespace Snouthill.Net.Packets.Account.Purse;

public record VoucherRedeemSuccess(
    List<(string Name, string Description)> Items) : IResponse
{
    public short Opcode => 212;

    public void Serialize(PacketWriter writer)
    {
        switch (Items.Count)
        {
            case > 2:
                writer.WriteString(string.Join(", ", Items.Select(item => item.Name).ToList()));
                writer.WriteString(string.Join(", ", Items.Select(item => item.Description).ToList()));
                break;

            case > 0:
                foreach (var (name, description) in Items)
                {
                    writer.WriteString(name);
                    writer.WriteString(description);
                }

                break;
        }
    }
}