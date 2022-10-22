namespace Snouthill.Networking.Messages.Room;

[Opcode(128)] // "GETPETSTAT"
public record SetPetStat : IInboundMessage<SetPetStat>
{
    public static SetPetStat Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}