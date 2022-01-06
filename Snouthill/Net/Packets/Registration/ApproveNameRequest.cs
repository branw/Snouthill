using Snouthill.Game;

namespace Snouthill.Net.Packets.Registration;

[RequestOpcode(42)] // "APPROVENAME"
public record ApproveNameRequest(
    string Name) : IRequest;

public class ApproveNameRequestDeserializer : IRequestDeserializer<ApproveNameRequest>
{
    public ApproveNameRequest Deserialize(PacketReader reader)
    {
        var name = reader.ReadString();

        return new ApproveNameRequest(name);
    }
}

public class ApproveNameRequestHandler : IRequestHandler<ApproveNameRequest>
{
    public void Handle(ApproveNameRequest request, Player player)
    {
        player.Send(new ApproveNameResponse(ApproveNameResponse.ReplyType.Accepted));
    }
}