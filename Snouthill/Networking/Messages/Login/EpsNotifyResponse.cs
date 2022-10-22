namespace Snouthill.Networking.Messages.Login;

[Opcode(52)] // hh_entry/Login Handler/handleEPSnotify 
public record EpsNotifyResponse : IOutboundMessage
{
    public void Serialize(PacketWriter message)
    {
        throw new NotImplementedException();
    }
}