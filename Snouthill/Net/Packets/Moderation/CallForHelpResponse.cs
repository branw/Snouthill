namespace Snouthill.Net.Packets.Moderation;

public record CallForHelpResponse(
    bool Successful,
    int? CryId,
    string? FormattedTimestamp,
    string? Message) : IResponse
{
    public short Opcode => 319;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteBool(Successful);
        if (!Successful || CryId == null || FormattedTimestamp == null || Message == null) return;

        writer.WriteString(CryId.ToString());
        writer.WriteString(FormattedTimestamp);
        writer.WriteString(Message);
    }
}