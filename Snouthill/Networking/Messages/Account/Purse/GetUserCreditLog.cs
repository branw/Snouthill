namespace Snouthill.Networking.Messages.Account.Purse;

[Opcode(127)] // "GETUSERCREDITLOG"
public record GetUserCreditLog : IInboundMessage<GetUserCreditLog>
{
    public static GetUserCreditLog Deserialize(PacketReader reader) => new();
}