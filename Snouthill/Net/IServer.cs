namespace Snouthill.Net;

public interface IServer<out TClient>
{
    IEnumerable<TClient> Clients { get; }

    Task AcceptConnectionsAsync(CancellationToken stoppingToken);
}