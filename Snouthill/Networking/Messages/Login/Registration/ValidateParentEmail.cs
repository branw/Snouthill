namespace Snouthill.Networking.Messages.Login.Registration;

[Opcode(147)] // "VALIDATE_PARENT_EMAIL"
public record ValidateParentEmail : IInboundMessage<ValidateParentEmail>
{
    public static ValidateParentEmail Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}