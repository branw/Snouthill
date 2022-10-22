namespace Snouthill.Networking.Messages.Inbound;

[Opcode(183)] // v10~13+ "CONVERT_FURNI_TO_CREDITS"
public record ConvertFurniToCredits : IInboundMessage<ConvertFurniToCredits>
{
    public static ConvertFurniToCredits Deserialize(PacketReader reader)
    {
        throw new NotImplementedException();
    }
}