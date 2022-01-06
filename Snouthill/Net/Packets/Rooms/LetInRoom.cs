namespace Snouthill.Net.Packets.Rooms;

public record LetInRoom : IResponse
{
    public short Opcode => 41;
}