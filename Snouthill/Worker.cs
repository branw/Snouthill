using Snouthill.Networking;
using Snouthill.Networking.Messages;

namespace Snouthill;

public class Worker : BackgroundService
{
    private readonly Server _gameServer;
    
    public Worker()
    {
        _gameServer = new Server(Config.GamePort);
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        OpcodeManager.Initialize();
        _gameServer.Load();
        
        await _gameServer.AcceptConnectionsAsync(stoppingToken);
    }
}