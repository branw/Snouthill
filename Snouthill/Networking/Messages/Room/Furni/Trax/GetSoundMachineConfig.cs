namespace Snouthill.Networking.Messages.Room.Furni.Trax;

[Opcode(217)] // "GET_SOUND_MACHINE_CONFIGURATION"
public record GetSoundMachineConfig : IInboundMessage<GetSoundMachineConfig>
{
    public static GetSoundMachineConfig Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}