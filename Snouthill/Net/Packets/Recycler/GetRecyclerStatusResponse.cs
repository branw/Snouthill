namespace Snouthill.Net.Packets.Recycler;

public record GetRecyclerStatusResponse(
    bool Enabled) : IResponse
{
    public short Opcode => 304;

    public void Serialize(PacketWriter writer)
    {
        if (!Enabled)
        {
            writer.WriteInt(0);
        }

        //TODO
    }
}