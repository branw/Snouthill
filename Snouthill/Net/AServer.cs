using System.Net;
using System.Net.Sockets;
using Serilog;

namespace Snouthill.Net;

public abstract class AServer<TClient> : IServer<TClient>
{
    private readonly List<TClient> _clients = new();

    private readonly TcpListener _listener;

    protected AServer(int port)
    {
        _listener = StartListener(port);
    }

    public IEnumerable<TClient> Clients => _clients;

    public async Task AcceptConnectionsAsync(CancellationToken stoppingToken)
    {
        Log.Information("Accepting connections");

        // Register token to stop the listener immediately
        stoppingToken.Register(() => _listener.Stop());

        // Begin accepting connections on the listener
        while (!stoppingToken.IsCancellationRequested)
            try
            {
                var socket = await _listener.AcceptSocketAsync(stoppingToken);

                var client = AcceptConnection(socket);
                if (client != null) _clients.Add(client);
            }
            catch (InvalidOperationException)
            {
                stoppingToken.ThrowIfCancellationRequested();
                throw;
            }
    }

    private static TcpListener StartListener(int port)
    {
        Log.Debug("Creating listener on port {port}", port);

        var listener = new TcpListener(IPAddress.Parse("127.0.0.1"), port);
        listener.Start();
        return listener;
    }

    protected abstract TClient? AcceptConnection(Socket socket);
}