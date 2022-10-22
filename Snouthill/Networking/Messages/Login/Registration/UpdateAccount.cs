namespace Snouthill.Networking.Messages.Login.Registration;

[Opcode(149)] // "UPDATE_ACCOUNT"
public record UpdateAccount : IInboundMessage<UpdateAccount>
{
    public static UpdateAccount Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}