using System.Net.Sockets;
using Snouthill.Game;
using Snouthill.Net.Packets.Handshake;

namespace Snouthill.Net;

public class GameServer : AServer<GameClient>
{
    private readonly IPlayerManager _playerManager;
    private readonly IRequestDispatcher _requestDispatcher;

    public GameServer(IRequestDispatcher requestDispatcher, IPlayerManager playerManager) : base(Config.GamePort)
    {
        _requestDispatcher = requestDispatcher;
        _playerManager = playerManager;
    }

    protected override GameClient AcceptConnection(Socket socket)
    {
        var client = new GameClient(socket, _requestDispatcher);

        _playerManager.AddPlayer(client.Player);

        client.Send(new Hello());

        return client;
    }
}