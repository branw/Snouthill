namespace Snouthill.Networking.Messages.Recycler;

[Opcode(303)] // [[#recycler_handler, #handle_recycler_configuration]]
public record RecyclerConfig(
    bool Enabled,
    List<string> Rewards,
    int ItemQuarantineSeconds,
    int DurationSeconds,
    int TimeoutSeconds) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        message.WriteBool(Enabled);
        message.WriteInt(ItemQuarantineSeconds / 60);
        message.WriteInt(DurationSeconds / 60);
        message.WriteInt(TimeoutSeconds / 60);

        message.WriteInt(Rewards.Count);
        //TODO
    }
}