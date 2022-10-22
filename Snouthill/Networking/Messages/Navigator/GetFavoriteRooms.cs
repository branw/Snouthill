namespace Snouthill.Networking.Messages.Navigator;

[Opcode(18)] // "GETFVRF"
public record GetFavoriteRooms(
    bool Unk) : IInboundMessage<GetFavoriteRooms>
{
    public static GetFavoriteRooms Deserialize(PacketReader message)
    {
        // Always false?
        var unk = message.ReadBool();

        return new GetFavoriteRooms(unk);
    }
}