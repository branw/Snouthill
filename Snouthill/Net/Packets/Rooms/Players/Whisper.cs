using Snouthill.Game;

namespace Snouthill.Net.Packets.Rooms.Players;

[RequestOpcode(56)]
public record Whisper(
    string RecipientName,
    string Message) : IRequest;

public class WhisperDeserializer : IRequestDeserializer<Whisper>
{
    public Whisper Deserialize(PacketReader reader)
    {
        var contents = reader.ReadString().Split(" ", 2);
        var recipientName = contents[0];
        var message = contents[1];

        return new Whisper(recipientName, message);
    }
}

public class WhisperHandler : IRequestHandler<Whisper>
{
    public void Handle(Whisper request, Player player)
    {
        RequestValidator.VerifyPlayerInRoom(player);

        if (player.IsTyping)
        {
            player.IsTyping = false;
            player.Room!.Send(new TypingStatus(0, false));
        }

        if (request.Message.Length == 0) return;

        player.Talk(TalkLevel.Whisper, request.Message, new List<string> {request.RecipientName});
    }
}