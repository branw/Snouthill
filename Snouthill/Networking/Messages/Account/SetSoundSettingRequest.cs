namespace Snouthill.Networking.Messages.Account;

[Opcode(229)] // "SET_SOUND_SETTING"
public record SetSoundSettingRequest(
    bool EnableSound) : IInboundMessage<SetSoundSettingRequest>
{
    public static SetSoundSettingRequest Deserialize(PacketReader reader)
    {
        var enableSound = reader.ReadInt() == 1;

        return new SetSoundSettingRequest(enableSound);
    }
}