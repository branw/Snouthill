namespace Snouthill.Networking.Messages.Messenger;

[Opcode(191)] // "MESSENGER_GETMESSAGES"
public record GetMessages : IInboundMessage<GetMessages>
{
    public static GetMessages Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}