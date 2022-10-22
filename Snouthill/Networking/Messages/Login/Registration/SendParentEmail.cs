namespace Snouthill.Networking.Messages.Login.Registration;

[Opcode(148)] // "SEND_PARENT_EMAIL"
public record SendParentEmail : IInboundMessage<SendParentEmail>
{
    public static SendParentEmail Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}