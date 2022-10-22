namespace Snouthill.Networking.Messages.Room.Furni.Trax;

[Opcode(218)] // "SAVE_SOUND_MACHINE_CONFIGURATION"
public record SaveSoundMachineConfig : IInboundMessage<SaveSoundMachineConfig>
{
    public static SaveSoundMachineConfig Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}