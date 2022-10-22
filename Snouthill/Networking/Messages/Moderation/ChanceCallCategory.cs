namespace Snouthill.Networking.Messages.Moderation;

[Opcode(198)] // "CHANGECALLCATEGORY"
public record ChangeCallCategory : IInboundMessage<ChangeCallCategory>
{
    public static ChangeCallCategory Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}