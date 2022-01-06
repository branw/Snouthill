using Serilog;

namespace Snouthill.Net.Packets.Club;

[RequestOpcode(190)] // "SCR_BUY"
public record SubscribeClubRequest(
    int Choice) : IRequest;

public class SubscribeClubRequestDeserializer : IRequestDeserializer<SubscribeClubRequest>
{
    public SubscribeClubRequest Deserialize(PacketReader reader)
    {
        var str = reader.ReadString();
        Log.Debug("str: {str}", str);

        var choice = reader.ReadInt();

        return new SubscribeClubRequest(choice);
    }
}