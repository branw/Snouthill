namespace Snouthill.Networking.Messages.Moderation;

[Opcode(238)] // "DELETE_PENDING_CALLS_FOR_HELP"
public record DeletePendingCallsForHelp : IInboundMessage<DeletePendingCallsForHelp>
{
    public static DeletePendingCallsForHelp Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}