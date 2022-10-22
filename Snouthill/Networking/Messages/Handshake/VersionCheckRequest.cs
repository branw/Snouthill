namespace Snouthill.Networking.Messages.Inbound;

[Opcode(5)] // "VERSIONCHECK"
public record VersionCheckRequest(
    // From variable "client.version.id"
    int VersionId,
    string ClientUrl,
    string ExternalVariablesUrl) : IInboundMessage<VersionCheckRequest>
{
    public static VersionCheckRequest Deserialize(PacketReader reader)
    {
        var versionId = reader.ReadInt();
        var clientUrl = reader.ReadString();
        var externalVariablesUrl = reader.ReadString();

        return new VersionCheckRequest(versionId, clientUrl, externalVariablesUrl);
    }
}