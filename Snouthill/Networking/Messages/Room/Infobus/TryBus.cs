namespace Snouthill.Networking.Messages.Room.Infobus;

[Opcode(113)] // "TRYBUS"
public record TryBus : IInboundMessage<TryBus>
{
    public static TryBus Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}