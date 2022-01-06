using Snouthill.Game;

namespace Snouthill.Net.Packets.Rooms;

[RequestOpcode(182)]
public record GetInterstitial(
    string? Type) : IRequest;

public class GetInterstitialDeserializer : IRequestDeserializer<GetInterstitial>
{
    public GetInterstitial Deserialize(PacketReader reader)
    {
        string? type = null;
        if (reader.Remaining > 0) type = reader.ReadRawString();

        return new GetInterstitial(type);
    }
}

public class GetInterstitialHandler : IRequestHandler<GetInterstitial>
{
    public void Handle(GetInterstitial request, Player player)
    {
        player.Send(new GetInterstitialResponse("", ""));
    }
}