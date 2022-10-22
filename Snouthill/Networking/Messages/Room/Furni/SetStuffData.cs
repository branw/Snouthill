namespace Snouthill.Networking.Messages.Room.Furni;

[Opcode(74)] // "SETSTUFFDATA
public record SetStuffData : IInboundMessage<SetStuffData>
{
    public static SetStuffData Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}