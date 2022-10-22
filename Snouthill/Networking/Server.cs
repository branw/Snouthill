using System.Net;
using System.Net.Sockets;
using Serilog;
using Snouthill.Game;
using Snouthill.Networking.Messages;
using Snouthill.Networking.Messages.Handshake;

namespace Snouthill.Networking;

public class Server
{
    private readonly List<Client> _clients = new();
    private readonly TcpListener _listener;

    public PlayerManager Players { get; } = new();
    public RoomManager Rooms { get; } = new();

    public Server(int port)
    {
        Log.Debug("Creating listener on port {Port}", port);

        _listener = new TcpListener(IPAddress.Parse("127.0.0.1"), port);
        _listener.Start();
    }

    public void Load()
    {
        OpcodeManager.Initialize();

        Players.Load();
        Rooms.Load();
    }

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

                var client = AcceptConnection(new Connection(socket));
                _clients.Add(client);
            }
            catch (InvalidOperationException)
            {
                stoppingToken.ThrowIfCancellationRequested();
                throw;
            }
    }

    private Client AcceptConnection(Connection connection)
    {
        var client = new Client(this, connection);

        client.Send(new Hello());

        return client;
    }
}