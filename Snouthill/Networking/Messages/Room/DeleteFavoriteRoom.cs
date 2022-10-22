namespace Snouthill.Networking.Messages.Room;

[Opcode(20)] // "DEL_FAVORITE_ROOM"
public record DeleteFavoriteRoom : IInboundMessage<DeleteFavoriteRoom>
{
    public static DeleteFavoriteRoom Deserialize(PacketReader reader) => new();
}