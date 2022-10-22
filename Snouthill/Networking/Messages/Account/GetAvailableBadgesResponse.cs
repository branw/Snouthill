using System.Collections.Immutable;
using Snouthill.Database.Models;

namespace Snouthill.Networking.Messages.Account;

[Opcode(229)] // [[#login_handler, #handleAvailableBadges]]
public record GetAvailableBadgesResponse(
    IReadOnlyList<string> Badges,
    string CurrentBadge,
    bool ShowBadge) : IOutboundMessage
{
    public GetAvailableBadgesResponse(IEnumerable<BadgeModel> badgeModels, PlayerModel playerModel) : this(
        badgeModels.Select(badgeModel => badgeModel.Name).ToImmutableList(),
        playerModel.CurrentBadge,
        playerModel.ShowBadge)
    {
    }

    public void Serialize(PacketWriter message)
    {
        message.WriteInt(Badges.Count);

        var currentBadgeSlot = 0;
        for (var i = 0; i < Badges.Count; i++)
        {
            message.WriteString(Badges[i]);

            if (Badges[i] == CurrentBadge) currentBadgeSlot = i;
        }

        message.WriteInt(currentBadgeSlot);
        message.WriteBool(ShowBadge);
    }
}