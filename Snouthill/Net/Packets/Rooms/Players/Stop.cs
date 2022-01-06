using Snouthill.Game;

namespace Snouthill.Net.Packets.Rooms.Players;

[RequestOpcode(88)]
public record Stop(
    string Action) : IRequest;

public class StopDeserialize : IRequestDeserializer<Stop>
{
    public Stop Deserialize(PacketReader reader)
    {
        var action = reader.ReadRawString();

        return new Stop(action);
    }
}

public class StopHandler : IRequestHandler<Stop>
{
    public void Handle(Stop request, Player player)
    {
    }
}