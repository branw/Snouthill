namespace Snouthill.Net.Packets.Handshake;

public record SessionParameters(
    IDictionary<SessionParameters.Parameter, string> Parameters) : IResponse
{
    public enum Parameter
    {
        RegisterCoppa = 0,
        VouchersEnabled = 1,
        RequestParentEmail = 2,
        RequestParentEmailReregistration = 3,
        AllowDirectMail = 4,
        DateFormat = 5,
        EnablePartnerIntegration = 6,
        AllowProfileEditing = 7,
        TrackingHeader = 8,
        EnableTutorial = 9
    }

    public short Opcode => 257;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteInt(Parameters.Count);
        foreach (var (key, value) in Parameters)
        {
            writer.WriteInt((int) key);

            if (value.Length > 0 && char.IsDigit(value[0]))
                writer.WriteInt(int.Parse(value));
            else
                writer.WriteString(value);
        }
    }
}