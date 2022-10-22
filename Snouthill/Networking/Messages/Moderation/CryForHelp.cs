namespace Snouthill.Networking.Messages.Moderation;

[Opcode(86)] // "CRYFORHELP"
public record CryForHelp : IInboundMessage<CryForHelp>
{
    public static CryForHelp Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}