using Snouthill.Database.Models;

namespace Snouthill.Networking.Messages.Account;

[Opcode(308)] // hh_entry/Login Handler/handleSoundSetting
public record GetSoundSettingResponse(
    bool SoundEnabled) : IOutboundMessage
{
    public GetSoundSettingResponse(PlayerModel playerModel) : this(playerModel.SoundEnabled)
    {
    }

    public void Serialize(PacketWriter message)
    {
        message.WriteBool(SoundEnabled);
    }
}