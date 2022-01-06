using Snouthill.Game;

namespace Snouthill.Net.Packets.Rooms.Players;

[RequestOpcode(55)]
public record Shout(
    string Message) : IRequest;

public class ShoutDeserializer : IRequestDeserializer<Shout>
{
    public Shout Deserialize(PacketReader reader)
    {
        var message = reader.ReadString();

        return new Shout(message);
    }
}

public class ShoutHandler : IRequestHandler<Shout>
{
    public void Handle(Shout request, Player player)
    {
        RequestValidator.VerifyPlayerAuthenticated(player);
        RequestValidator.VerifyPlayerInRoom(player);

        if (player.IsTyping)
        {
            player.IsTyping = false;
            player.Room!.Send(new TypingStatus(0, false));
        }

        if (request.Message.Length == 0) return;

        player.Talk(TalkLevel.Chat, request.Message);
    }
}