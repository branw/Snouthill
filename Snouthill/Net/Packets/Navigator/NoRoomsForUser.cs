namespace Snouthill.Net.Packets.Navigator;

public record NoRoomsForUser(
    string Name) : IResponse
{
    public short Opcode => 57;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteString(Name);
    }
}