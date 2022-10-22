namespace Snouthill.Networking.Messages.Login.Registration;

[Opcode(49)] // "GDATE"
public record GetDate : IInboundMessage<GetDate>
{
    public static GetDate Deserialize(PacketReader reader) => new();

    public void Handle(Client client)
    {
        client.Send(ServerDate.Now);
    }
}