namespace Snouthill.Networking.Messages.Login.Registration;

[Opcode(197)] // "APPROVEEMAIL"
public record ApproveEmail(
    string Email) : IInboundMessage<ApproveEmail>
{
    public static ApproveEmail Deserialize(PacketReader reader)
    {
        var email = reader.ReadString();

        return new ApproveEmail(email);
    }

    public void Handle(Client client)
    {
        client.Send(new EmailApproved());
    }
}