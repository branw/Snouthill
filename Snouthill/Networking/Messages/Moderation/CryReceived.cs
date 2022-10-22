namespace Snouthill.Networking.Messages.Moderation;

[Opcode(321)]
public record CryReceived : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        message.WriteRawString("H");
    }
}