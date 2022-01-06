using Snouthill.Db;
using Snouthill.Game;
using Snouthill.Net.Packets.Outbound;

namespace Snouthill.Net.Packets.Handshake;

[RequestOpcode(4)]
public record LoginRequest(
    string Name,
    string Password) : IRequest;

public class LoginRequestDeserializer : IRequestDeserializer<LoginRequest>
{
    public LoginRequest Deserialize(PacketReader reader)
    {
        var username = reader.ReadString();
        var password = reader.ReadString();

        return new LoginRequest(username, password);
    }
}

public class LoginRequestHandler : IRequestHandler<LoginRequest>
{
    public void Handle(LoginRequest request, Player player)
    {
        using (var db = new DatabaseContext())
        {
            var playerModel = db.Players.Find(request.Name);
            if (playerModel == null)
            {
                player.Send(new LocalizedError(LocalizedError.ErrorType.IncorrectPassword));
                return;
            }

            if (playerModel.Password != request.Password)
            {
                player.Send(new LocalizedError(LocalizedError.ErrorType.IncorrectPassword));
                return;
            }
        }

        player.Send(new LoginSuccessfulResponse());

        player.Name = request.Name;
    }
}