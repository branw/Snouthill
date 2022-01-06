namespace Snouthill.Net.Packets.User;

[RequestOpcode(357)]
public record AcceptTutorInvitationRequest(
    string PlayerId) : IRequest;

public class AcceptTutorInvitationRequestDeserializer : IRequestDeserializer<AcceptTutorInvitationRequest>
{
    public AcceptTutorInvitationRequest Deserialize(PacketReader reader)
    {
        var playerId = reader.ReadString();

        return new AcceptTutorInvitationRequest(playerId);
    }
}