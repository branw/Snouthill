namespace Snouthill.Networking.Messages.Navigator;

[Opcode(17)] // "SRCHF"
public record SearchRooms(
    string Query) : IInboundMessage<SearchRooms>
{
    public static SearchRooms Deserialize(PacketReader reader)
    {
        var query = reader.ReadRawString();

        return new SearchRooms(query);
    }
}