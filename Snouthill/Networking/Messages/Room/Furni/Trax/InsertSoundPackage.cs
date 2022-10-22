namespace Snouthill.Networking.Messages.Room.Furni.Trax;

[Opcode(219)] // "INSERT_SOUND_PACKAGE"
public record InsertSoundPackage : IInboundMessage<InsertSoundPackage>
{
    public static InsertSoundPackage Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}