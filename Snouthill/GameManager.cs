using Microsoft.Extensions.Hosting;
using Serilog;
using Snouthill.Db;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snouthill
{
    public class GameManager : IHostedService
    {
        private Game _game;
        private Task _gameTask;
        private readonly CancellationTokenSource _stoppingTokenSrc = new CancellationTokenSource();

        public void Initialize()
        {
            Log.Information("Initializing database (source={databaseSource}, path={databasePath})",
                Config.Instance.DatabaseSource, Config.Instance.DatabasePath);
            using (var db = new Database())
            {
                db.Database.EnsureCreated();
            }

            Log.Information("Initializing game");
            _game = new Game();
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Initialize();

            _gameTask = _game.RunAsync(_stoppingTokenSrc.Token);
            if (_gameTask.IsCompleted)
            {
                return _gameTask;
            }

            return Task.CompletedTask;
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            // Stop called without start
            if (_gameTask == null)
            {
                return;
            }

            try
            {
                // Signal cancellation to the game
                _stoppingTokenSrc.Cancel();
            }
            finally
            {
                // Wait for either the game to stop or the token to cancel
                await Task.WhenAny(_gameTask,
                    Task.Delay(Timeout.Infinite, cancellationToken));
            }
        }
    }
}
