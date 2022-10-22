namespace Snouthill.Networking.Messages.Room;

[Opcode(90)] // "PLACESTUFF"
public record PlaceStuff : IInboundMessage<PlaceStuff>
{
    public static PlaceStuff Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}