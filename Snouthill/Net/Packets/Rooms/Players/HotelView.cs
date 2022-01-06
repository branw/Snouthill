namespace Snouthill.Net.Packets.Rooms.Players;

public record HotelView : IResponse
{
    public short Opcode => 18;
}