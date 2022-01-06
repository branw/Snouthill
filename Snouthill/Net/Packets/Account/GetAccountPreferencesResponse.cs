using Snouthill.Db.Models;

namespace Snouthill.Net.Packets.Account;

public record GetAccountPreferencesResponse(
    bool SoundEnabled,
    bool TutorialAvailable) : IResponse
{
    public GetAccountPreferencesResponse(PlayerModel playerModel) :
        this(playerModel.SoundEnabled, !playerModel.TutorialCompleted)
    {
    }

    public short Opcode => 308;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteBool(SoundEnabled);
        writer.WriteBool(TutorialAvailable);
    }
}