using Serilog;
using Snouthill.Game;

namespace Snouthill.Net.Packets.Rooms.Players;

[RequestOpcode(52)]
public record Chat(
    string Message) : IRequest;

public class ChatDeserializer : IRequestDeserializer<Chat>
{
    public Chat Deserialize(PacketReader reader)
    {
        var message = reader.ReadString();

        return new Chat(message);
    }
}

public class ChatHandler : IRequestHandler<Chat>
{
    public void Handle(Chat request, Player player)
    {
        if (player.Room == null)
        {
            Log.Error("Player {playerName} sent a room request from outside of a room", player.Name);
            return;
        }

        if (player.IsTyping)
        {
            player.IsTyping = false;
            player.Room.Send(new TypingStatus(0, false));
        }

        if (request.Message.Length == 0) return;

        player.Talk(TalkLevel.Chat, request.Message);
    }
}