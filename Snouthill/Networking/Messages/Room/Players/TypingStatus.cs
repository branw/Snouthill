namespace Snouthill.Networking.Messages.Room.Players;

[Opcode(361)] // [[#room_handler, #handle_user_typing_status]]
public record TypingStatus(
    int EntityId,
    bool IsTyping) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        message.WriteInt(EntityId);
        message.WriteBool(IsTyping);
    }
}