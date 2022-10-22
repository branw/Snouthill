namespace Snouthill.Networking.Messages.Room;

[Opcode(82)] // "DOORGOIN"
public record GoInDoor : IInboundMessage<GoInDoor>
{
    public static GoInDoor Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}