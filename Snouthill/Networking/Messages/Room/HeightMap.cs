namespace Snouthill.Networking.Messages.Room;

[Opcode(31)] // [[#room_handler, #handle_heightmap]]
public record HeightMap(
    string Map) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        message.WriteRawString(Map);
    }
}