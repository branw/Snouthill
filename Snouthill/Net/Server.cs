using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snouthill.Net
{
    public class Server
    {
        public Game Game { get; }

        public IEnumerable<Client> Clients { get => _clients; }

        public IDictionary<string, Type> PacketHandlers { get; }

        private List<TcpListener> _listeners;
        private List<Client> _clients;

        public Server(Game game)
        {
            Game = game;

            // Create listeners for login and each public room
            var startingPort = ServerConfig.MainPort;
            _listeners = new List<TcpListener>
            {
                StartListener(startingPort)
            };
            _listeners.AddRange(
                Game.RoomManager.GetPublicRooms()
                .Select(room => StartListener(startingPort + room.Info.Id)));

            // Create list of clients
            _clients = new List<Client>(); 
        }

        private TcpListener StartListener(int port)
        {
            Log.Debug("Creating listener on port {port}", port);

            var listener = new TcpListener(IPAddress.Parse("127.0.0.1"), port);
            listener.Start();
            return listener;
        }

        public async Task AcceptConnectionsAsync(CancellationToken stoppingToken)
        {
            Log.Information("Accepting connections");

            // Register token to stop all listeners immediately
            _listeners.Select(listener => stoppingToken.Register(() => listener.Stop()));

            // Begin accepting connections on all listeners
            await Task.WhenAll(_listeners.Select(async listener =>
            {
                while (!stoppingToken.IsCancellationRequested)
                {
                    try
                    {
                        var socket = await listener.AcceptSocketAsync();
                        if (socket == null)
                        {
                            break;
                        }

                        AcceptConnection(socket);
                    }
                    catch (InvalidOperationException)
                    {
                        stoppingToken.ThrowIfCancellationRequested();
                        throw;
                    }
                }
            }));
        }

        private void AcceptConnection(Socket socket)
        {
            var ip = ((IPEndPoint)socket.RemoteEndPoint).Address.ToString();

            Log.Information("Accepted connection from {ip}", ip);

            var client = new Client(this, socket);
            client.Send(new Outbound.Hello());

            _clients.Add(client);
        }
    }
}
