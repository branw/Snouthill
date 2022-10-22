namespace Snouthill.Networking.Messages.Login.Registration;

// Only used in Chinese hotels. This shows a prompt during registration that opens URL "partner.registration.url"
// with the user id appended.
[Opcode(281)] // hh_patch_cn/EBoss Handler/handle_partnerregistration 
public record PartnerRegistration(
    string UserId) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        throw new NotImplementedException();
    }
}