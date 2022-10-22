namespace Snouthill.Networking.Messages.Login.Registration;

[Opcode(42)] // "APPROVENAME"
public record ApproveName(
    string Name) : IInboundMessage<ApproveName>
{
    public static ApproveName Deserialize(PacketReader reader)
    {
        var name = reader.ReadString();

        return new ApproveName(name);
    }

    public void Handle(Client client)
    {
        client.Send(new NameApproved(NameApproved.ReplyType.Accepted));
    }
}