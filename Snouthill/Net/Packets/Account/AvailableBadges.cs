using System.Collections.Immutable;
using Snouthill.Db.Models;

namespace Snouthill.Net.Packets.Account;

public record AvailableBadges(
    IReadOnlyList<string> Badges,
    string CurrentBadge,
    bool ShowBadge) : IResponse
{
    public AvailableBadges(IEnumerable<BadgeModel> badgeModels, PlayerModel playerModel) : this(
        badgeModels.Select(badgeModel => badgeModel.Name).ToImmutableList(),
        playerModel.CurrentBadge,
        playerModel.ShowBadge)
    {
    }

    public short Opcode => 229;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteInt(Badges.Count);

        var currentBadgeSlot = 0;
        for (var i = 0; i < Badges.Count; i++)
        {
            writer.WriteString(Badges[i]);

            if (Badges[i] == CurrentBadge) currentBadgeSlot = i;
        }

        writer.WriteInt(currentBadgeSlot);
        writer.WriteBool(ShowBadge);
    }
}