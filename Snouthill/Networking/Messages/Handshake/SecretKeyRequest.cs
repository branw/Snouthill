namespace Snouthill.Networking.Messages.Inbound;

[Opcode(207)] // "SECRETKEY"
public record SecretKeyRequest : IInboundMessage<SecretKeyRequest>
{
    public static SecretKeyRequest Deserialize(PacketReader reader) => new();
}