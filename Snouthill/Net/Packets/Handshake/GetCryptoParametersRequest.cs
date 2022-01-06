using Snouthill.Game;

namespace Snouthill.Net.Packets.Handshake;

[RequestOpcode(206)]
public record GetCryptoParametersRequest : IRequest;

public class GetCryptoParametersRequestHandler : IRequestHandler<GetCryptoParametersRequest>
{
    public void Handle(GetCryptoParametersRequest request, Player player)
    {
        player.Send(new GetCryptoParametersResponse());
    }
}