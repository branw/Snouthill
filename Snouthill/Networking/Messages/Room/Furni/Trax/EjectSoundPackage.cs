namespace Snouthill.Networking.Messages.Room.Furni.Trax;

[Opcode(220)] // "EJECT_SOUND_PACKAGE"
public record EjectSoundPackage : IInboundMessage<EjectSoundPackage>
{
    public static EjectSoundPackage Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}