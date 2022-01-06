namespace Snouthill.Net.Packets.Account;

[RequestOpcode(229)]
public record SetSoundSettingRequest(bool EnableSound) : IRequest;

public class SetSoundSettingRequestDeserializer : IRequestDeserializer<SetSoundSettingRequest>
{
    public SetSoundSettingRequest Deserialize(PacketReader reader)
    {
        var enableSound = reader.ReadInt() == 1;

        return new SetSoundSettingRequest(enableSound);
    }
}