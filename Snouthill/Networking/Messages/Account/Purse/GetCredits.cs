namespace Snouthill.Networking.Messages.Account.Purse;

[Opcode(8)] // "GET_CREDITS"
public record GetCredits() : IInboundMessage<GetCredits>
{
    public static GetCredits Deserialize(PacketReader reader) => new();

    public void Handle(Client client)
    {
        client.Send(new CreditBalance("1337"));
    }
}