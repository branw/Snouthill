using Snouthill.Game;
using Snouthill.Net.Packets.Account;

namespace Snouthill.Net.Packets.Handshake;

[RequestOpcode(202)] // "GENERATEKEY"
public record GenerateKeyRequest : IRequest;

public class GenerateKeyRequestHandler : IRequestHandler<GenerateKeyRequest>
{
    public void Handle(GenerateKeyRequest request, Player player)
    {
        player.Send(new SessionParameters(new Dictionary<SessionParameters.Parameter, string>
        {
            {SessionParameters.Parameter.VouchersEnabled, "1"},
            {SessionParameters.Parameter.RequestParentEmail, "0"},
            {SessionParameters.Parameter.RequestParentEmailReregistration, "0"},
            {SessionParameters.Parameter.AllowDirectMail, "1"},
            {SessionParameters.Parameter.DateFormat, "dd-MM-yyyy"},
            {SessionParameters.Parameter.EnablePartnerIntegration, "1"},
            {SessionParameters.Parameter.AllowProfileEditing, "1"},
            {SessionParameters.Parameter.TrackingHeader, ""},
            {SessionParameters.Parameter.EnableTutorial, "1"}
        }));

        player.Send(new AvailableSets());
    }
}