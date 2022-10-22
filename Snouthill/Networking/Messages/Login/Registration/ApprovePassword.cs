namespace Snouthill.Networking.Messages.Login.Registration;

[Opcode(203)] // "APPROVE_PASSWORD"
public record ApprovePassword(
    string Name,
    string Password) : IInboundMessage<ApprovePassword>
{
    public static ApprovePassword Deserialize(PacketReader reader)
    {
        var name = reader.ReadString();
        var password = reader.ReadString();

        return new ApprovePassword(name, password);
    }

    public void Handle(Client client)
    {
        client.Send(new PasswordApproved(PasswordApproved.ReplyType.Approved));
    }
};