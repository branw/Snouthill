namespace Snouthill.Net.Packets;

public interface IRequestDeserializer<out TRequest> where TRequest : IRequest
{
    public TRequest Deserialize(PacketReader reader);
}