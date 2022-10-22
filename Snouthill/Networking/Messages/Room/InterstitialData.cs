namespace Snouthill.Networking.Messages.Room;

[Opcode(258)] // [[#room_handler, #handle_interstitialdata]]
public record InterstitialData(
    string ImageUrl,
    string LinkUrl) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        message.WriteInt(0);
    }
}