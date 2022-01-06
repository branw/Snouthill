using Snouthill.Game;
using Snouthill.Net;

namespace Snouthill;

public class Worker : BackgroundService
{
    private readonly IServer<GameClient> _gameServer;

    private readonly List<IManager> _managers;

    public Worker(IServer<GameClient> gameServer, ICatalogManager catalogManager, IPlayerManager playerManager,
        IRoomManager roomManager, IRoomLayoutManager roomLayoutManager)
    {
        _gameServer = gameServer;

        _managers = new List<IManager>
        {
            catalogManager,
            playerManager,
            roomManager,
            roomLayoutManager
        };
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _managers.AsParallel().ForAll(manager => manager.Initialize());

        await Task.WhenAll(
            ProcessEventsAsync(stoppingToken),
            _gameServer.AcceptConnectionsAsync(stoppingToken));
    }

    private async Task ProcessEventsAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
            //Log.Information("Worker running at: {time}", DateTimeOffset.Now);
            await Task.Delay(10000, stoppingToken);
    }
}