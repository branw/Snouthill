using Snouthill.Database;
using Snouthill.Database.Models;

namespace Snouthill.Networking.Messages.Account;

[Opcode(228)] // "GET_ACCOUNT_PREFERENCES" and "GET_SOUND_SETTING"
public record GetSoundSetting : IInboundMessage<GetSoundSetting>
{
    public static GetSoundSetting Deserialize(PacketReader reader) => new();

    public void Handle(Client client)
    {
        if (client.Player == null) throw new PlayerNotAuthenticatedException();

        client.Send(new GetSoundSettingResponse(client.Player.Model));
    }
}