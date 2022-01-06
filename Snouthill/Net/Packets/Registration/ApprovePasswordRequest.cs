using Snouthill.Game;

namespace Snouthill.Net.Packets.Registration;

[RequestOpcode(203)] // "APPROVE_PASSWORD"
public record ApprovePasswordRequest(
    string Name,
    string Password) : IRequest;

public class ApprovePasswordRequestDeserializer : IRequestDeserializer<ApprovePasswordRequest>
{
    public ApprovePasswordRequest Deserialize(PacketReader reader)
    {
        var name = reader.ReadString();
        var password = reader.ReadString();

        return new ApprovePasswordRequest(name, password);
    }
}

public class ApprovePasswordRequestHandler : IRequestHandler<ApprovePasswordRequest>
{
    public void Handle(ApprovePasswordRequest request, Player player)
    {
        player.Send(new ApprovePasswordResponse(ApprovePasswordResponse.ReplyType.Approved));
    }
}