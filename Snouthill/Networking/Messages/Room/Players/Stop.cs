namespace Snouthill.Networking.Messages.Room.Players;

[Opcode(88)] // "STOP"
public record Stop(
    string Action) : IInboundMessage<Stop>
{
    public static Stop Deserialize(PacketReader reader)
    {
        var action = reader.ReadRawString();

        return new Stop(action);
    }
}