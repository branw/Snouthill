namespace Snouthill.Networking.Messages.Room.DynamicDownloader;

[Opcode(215)] // "GET_ALIAS_LIST"
public record GetAliasList : IInboundMessage<GetAliasList>
{
    public static GetAliasList Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}