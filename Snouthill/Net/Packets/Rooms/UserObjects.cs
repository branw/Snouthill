using Snouthill.Game;

namespace Snouthill.Net.Packets.Rooms;

public record UserObjects(
    IEnumerable<AEntity> Entities) : IResponse
{
    public short Opcode => 28;

    public void Serialize(PacketWriter writer)
    {
        foreach (var entity in Entities) writer.WriteRawString("\r");
    }
}