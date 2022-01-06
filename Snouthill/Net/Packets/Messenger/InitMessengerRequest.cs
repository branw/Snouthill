using Snouthill.Game;

namespace Snouthill.Net.Packets.Messenger;

[RequestOpcode(12)]
public record InitMessengerRequest : IRequest;

public class InitMessengerRequestHandler : IRequestHandler<InitMessengerRequest>
{
    public void Handle(InitMessengerRequest request, Player player)
    {
        player.Send(new InitMessengerResponse("Hello", 10, 5, 8, new List<string> {"a", "b"}));

        //TODO handle requests
    }
}