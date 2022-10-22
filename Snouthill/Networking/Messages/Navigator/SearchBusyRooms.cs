namespace Snouthill.Networking.Messages.Navigator;

[Opcode(13)] // <v7 "SBUSYF"
public record SearchBusyRooms : IInboundMessage<SearchBusyRooms>
{
    public static SearchBusyRooms Deserialize(PacketReader reader) => new();
}