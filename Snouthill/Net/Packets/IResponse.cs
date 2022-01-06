namespace Snouthill.Net.Packets;

public interface IResponse
{
    short Opcode { get; }

    void Serialize(PacketWriter writer)
    {
    }
}