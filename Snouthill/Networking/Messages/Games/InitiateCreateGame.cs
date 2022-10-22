namespace Snouthill.Networking.Messages.Games;

[Opcode(162)] // "INITIATECREATEGAME"
public record InitiateCreateGame : IInboundMessage<InitiateCreateGame>
{
    public static InitiateCreateGame Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}