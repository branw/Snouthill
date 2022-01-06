namespace Snouthill.Net.Packets.Rooms.Players;

public record TypingStatus(
    int EntityId,
    bool IsTyping) : IResponse
{
    public short Opcode => 361;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteInt(EntityId);
        writer.WriteBool(IsTyping);
    }
}