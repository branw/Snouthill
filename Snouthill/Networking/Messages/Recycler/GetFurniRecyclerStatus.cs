namespace Snouthill.Networking.Messages.Recycler;

[Opcode(223)] // "GET_FURNI_RECYCLER_STATUS"
public record GetFurniRecyclerStatus : IInboundMessage<GetFurniRecyclerStatus>
{
    public static GetFurniRecyclerStatus Deserialize(PacketReader reader) => new();

    public void Handle(Client client)
    {
        client.Send(new RecyclerStatus(false));
    }
}