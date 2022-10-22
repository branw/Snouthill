namespace Snouthill.Networking.Messages.Login.Registration;

[Opcode(146)] // "PARENT_EMAIL_REQUIRED"
public record ParentEmailRequired : IInboundMessage<ParentEmailRequired>
{
    public static ParentEmailRequired Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}