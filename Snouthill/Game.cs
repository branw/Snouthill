using Serilog;
using Snouthill.Net;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snouthill
{
    public class Game
    {
        public Server Server { get; }

        public RoomManager RoomManager { get; }

        public Game()
        {
            Log.Information("Initializing room manager");
            RoomManager = new RoomManager(this);

            Log.Information("Initializing server");
            Server = new Server(this);
        }

        public async Task RunAsync(CancellationToken stoppingToken)
        {
            await Task.WhenAll(
                ProcessEventsAsync(stoppingToken),
                Server.AcceptConnectionsAsync(stoppingToken));
        }

        public async Task ProcessEventsAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {


                await Task.Delay(Config.Instance.Timestep, stoppingToken);
            }
        }
    }
}
