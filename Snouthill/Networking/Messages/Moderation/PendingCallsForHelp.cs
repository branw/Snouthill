using Snouthill.Game;

namespace Snouthill.Networking.Messages.Moderation;

[Opcode(319)] // [[#dialogs_handler, #handle_get_pending_response]]
public record PendingCallsForHelp(
    bool Successful,
    int? CryId = null,
    string? FormattedTimestamp = null,
    string? Message = null) : IOutboundMessage
{
    public PendingCallsForHelp(CallForHelp? cfh) : this(
        cfh != null,
        cfh?.CryId,
        cfh?.CallTime != null ? DateTimeOffset.FromUnixTimeSeconds(cfh.CallTime).ToString("HH:mm d/MM/YYYY") : null,
        cfh?.Message)
    {
    }

    public void Serialize(PacketWriter message)
    {
        message.WriteBool(Successful);
        if (!Successful || CryId == null || FormattedTimestamp == null || Message == null) return;

        message.WriteString(CryId.ToString()!);
        message.WriteString(FormattedTimestamp);
        message.WriteString(Message);
    }
}