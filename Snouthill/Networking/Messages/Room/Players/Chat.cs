using Snouthill.Game;

namespace Snouthill.Networking.Messages.Room.Players;

[Opcode(52)] // "CHAT"
public record Chat(
    string Message) : IInboundMessage<Chat>
{
    public static Chat Deserialize(PacketReader reader)
    {
        var message = reader.ReadString();

        return new Chat(message);
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

        client.Player.Talk(TalkLevel.Chat, Message);
    }
}