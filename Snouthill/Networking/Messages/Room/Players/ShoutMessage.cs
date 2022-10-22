namespace Snouthill.Networking.Messages.Room.Players;

[Opcode(26)]
public record ShoutMessage(
    int EntityId,
    string Message) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        message.WriteInt(EntityId);
        message.WriteString(Message);
    }
}