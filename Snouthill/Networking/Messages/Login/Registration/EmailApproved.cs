namespace Snouthill.Networking.Messages.Login.Registration;

[Opcode(271)] // hh_registrat/handle_email_approved
public record EmailApproved : IOutboundMessage;