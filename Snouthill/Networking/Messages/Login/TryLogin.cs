using Snouthill.Game;
using Snouthill.Networking.Messages.Util;

namespace Snouthill.Networking.Messages.Login;

[Opcode(4)] // "TRY_LOGIN"
public record TryLogin(
    string Name,
    string Password) : IInboundMessage<TryLogin>
{
    public static TryLogin Deserialize(PacketReader reader)
    {
        var username = reader.ReadString();
        var password = reader.ReadString();

        return new TryLogin(username, password);
    }

    public void Handle(Client client)
    {
        var player = Player.Login(client, Name, Password);
        if (player == null)
        {
            client.Send(LocalizedError.IncorrectPassword);
            return;
        }

        client.Send(new LoginSuccessful());

        client.Player = player;
    }
}