namespace Snouthill.Networking.Messages.Room.DynamicDownloader;

[Opcode(213)] // "GET_FURNI_REVISIONS"
public record GetFurniRevisions : IInboundMessage<GetFurniRevisions>
{
    public static GetFurniRevisions Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}