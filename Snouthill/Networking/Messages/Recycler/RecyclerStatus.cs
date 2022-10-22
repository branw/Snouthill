namespace Snouthill.Networking.Messages.Recycler;

[Opcode(304)] // [[#recycler_handler, #handle_recycler_status]]
public record RecyclerStatus(
    bool Enabled) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        if (!Enabled) message.WriteInt(0);

        throw new NotImplementedException();
    }
}