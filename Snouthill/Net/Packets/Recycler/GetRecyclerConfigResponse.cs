namespace Snouthill.Net.Packets.Recycler;

public record GetRecyclerConfigResponse(
    bool Enabled,
    List<string> Rewards,
    int ItemQuarantineSeconds,
    int DurationSeconds,
    int TimeoutSeconds) : IResponse
{
    public short Opcode => 303;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteBool(Enabled);
        writer.WriteInt(ItemQuarantineSeconds / 60);
        writer.WriteInt(DurationSeconds / 60);
        writer.WriteInt(TimeoutSeconds / 60);

        writer.WriteInt(Rewards.Count);
        //TODO
    }
}