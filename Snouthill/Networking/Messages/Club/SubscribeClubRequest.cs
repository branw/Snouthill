using Serilog;

namespace Snouthill.Networking.Messages.Club;

[Opcode(190)] // "SCR_BUY"
public record SubscribeClubRequest(
    string Club,
    int Choice) : IInboundMessage<SubscribeClubRequest>
{
    public static SubscribeClubRequest Deserialize(PacketReader reader)
    {
        var club = reader.ReadString();
        var choice = reader.ReadInt();

        return new SubscribeClubRequest(club, choice);
    }
}