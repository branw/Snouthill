using Snouthill.Game;

namespace Snouthill.Net.Packets;

public interface IRequestHandler<in TRequest> where TRequest : IRequest
{
    public void Handle(TRequest request, Player player);
}