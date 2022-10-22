using Snouthill.Game;

namespace Snouthill.Networking.Messages.Room.Players;

[Opcode(56)] // "WHISPER"
public record Whisper(
    string RecipientName,
    string Message) : IInboundMessage<Whisper>
{
    public static Whisper Deserialize(PacketReader reader)
    {
        var contents = reader.ReadString().Split(" ", 2);
        var recipientName = contents[0];
        var message = contents[1];

        return new Whisper(recipientName, message);
    }

    public void Handle(Client client)
    {
        if (client.Player == null) throw new PlayerNotAuthenticatedException();
        if (client.Player.Room == null) throw new PlayerNotInRoomException();

        if (client.Player.IsTyping)
        {
            client.Player.IsTyping = false;
            client.Player.Room.Send(new TypingStatus(0, false));
        }
        
        if (Message.Length == 0) return;

        client.Player.Talk(TalkLevel.Whisper, Message, new List<string> {RecipientName});
    }
}