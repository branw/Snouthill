namespace Snouthill.Networking.Messages.Inbound;

[Opcode(89)] // v7-v29 "USEITEM", v30+ "USEOBJECT"
public record UseItem : IInboundMessage<UseItem>
{
    public static UseItem Deserialize(PacketReader reader)
    {
        throw new NotImplementedException();
    }
}