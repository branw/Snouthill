namespace Snouthill.Networking.Messages.Recycler;

[Opcode(222)] // "GET_FURNI_RECYCLER_CONFIGURATION"
public record GetRecyclerConfig : IInboundMessage<GetRecyclerConfig>
{
    public static GetRecyclerConfig Deserialize(PacketReader reader) => new();

    public void Handle(Client client)
    {
        client.Send(new RecyclerConfig(false, new List<string>(), 0, 0, 0));

    }
}