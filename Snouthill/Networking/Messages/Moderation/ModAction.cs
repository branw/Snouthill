namespace Snouthill.Networking.Messages.Moderation;

[Opcode(200)] // "MODERATIONACTION"
public record ModAction : IInboundMessage<ModAction>
{
    public static ModAction Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}