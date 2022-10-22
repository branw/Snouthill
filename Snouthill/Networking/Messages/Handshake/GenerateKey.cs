using Snouthill.Networking.Messages.Account;

namespace Snouthill.Networking.Messages.Handshake;

[Opcode(202)] // "GENERATEKEY"
public record GenerateKey : IInboundMessage<GenerateKey>
{
    public static GenerateKey Deserialize(PacketReader reader) => new();

    public void Handle(Client client)
    {
        client.Send(new SessionParameters(new Dictionary<SessionParameters.Parameter, string>
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

        client.Send(AvailableSets.Default);
    }
}