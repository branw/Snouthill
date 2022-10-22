namespace Snouthill.Networking.Messages.Account.Purse;

[Opcode(212)] // hh_purse::handle_purse
public record VoucherRedeemSuccess(
    List<(string Name, string Description)> Items) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        switch (Items.Count)
        {
            case > 2:
                message.WriteString(string.Join(", ", Items.Select(item => item.Name).ToList()));
                message.WriteString(string.Join(", ", Items.Select(item => item.Description).ToList()));
                break;

            case > 0:
                foreach (var (name, description) in Items)
                {
                    message.WriteString(name);
                    message.WriteString(description);
                }

                break;
        }
    }
}