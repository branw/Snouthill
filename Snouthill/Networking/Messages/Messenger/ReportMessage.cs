namespace Snouthill.Networking.Messages.Messenger;

[Opcode(201)] // "MESSENGER_REPORTMESSAGE"
public record ReportMessage : IInboundMessage<ReportMessage>
{
    public static ReportMessage Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}