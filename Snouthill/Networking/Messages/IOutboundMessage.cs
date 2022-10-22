namespace Snouthill.Networking.Messages;

public interface IOutboundMessage
{
    void Serialize(PacketWriter message)
    {
    }
}