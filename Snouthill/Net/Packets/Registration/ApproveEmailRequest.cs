using Snouthill.Game;

namespace Snouthill.Net.Packets.Registration;

[RequestOpcode(197)]
public record ApproveEmailRequest(
    string Email) : IRequest;

public class ApproveEmailRequestDeserialize : IRequestDeserializer<ApproveEmailRequest>
{
    public ApproveEmailRequest Deserialize(PacketReader reader)
    {
        var email = reader.ReadString();

        return new ApproveEmailRequest(email);
    }
}

public class ApproveEmailRequestHandler : IRequestHandler<ApproveEmailRequest>
{
    public void Handle(ApproveEmailRequest request, Player player)
    {
        player.Send(new ApproveEmailResponse());
    }
}