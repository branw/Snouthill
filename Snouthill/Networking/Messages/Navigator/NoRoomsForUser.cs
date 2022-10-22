namespace Snouthill.Networking.Messages.Navigator;

[Opcode(57)] // [[#navigator_handler, #handle_noflatsforuser]]
public record NoRoomsForUser(
    string Name) : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        message.WriteString(Name);
    }
}