namespace Snouthill.Networking.Messages.Handshake;

[Opcode(257)] // [[#login_handler, #handleSessionParameters]]
public record SessionParameters(
    IDictionary<SessionParameters.Parameter, string> Parameters) : IOutboundMessage
{
    public enum Parameter
    {
        // "conf_coppa"/"conf_strong_coppa_required"
        RegisterCoppa = 0,

        // "conf_voucher"
        VouchersEnabled = 1,

        // "conf_parent_email_request"
        RequestParentEmail = 2,

        // "conf_parent_email_request_reregistration"
        RequestParentEmailReregistration = 3,

        // "conf_allow_direct_mail"
        AllowDirectMail = 4,
        DateFormat = 5,

        // "conf_partner_integration"
        EnablePartnerIntegration = 6,

        // "allow_profile_editing"
        AllowProfileEditing = 7,

        // "tracking_header"
        TrackingHeader = 8,

        // "tutorial_enabled"
        EnableTutorial = 9
    }

    public void Serialize(PacketWriter message)
    {
        message.WriteInt(Parameters.Count);
        foreach (var (key, value) in Parameters)
        {
            message.WriteInt((int) key);

            if (value.Length > 0 && char.IsDigit(value[0]))
                message.WriteInt(int.Parse(value));
            else
                message.WriteString(value);
        }
    }
}