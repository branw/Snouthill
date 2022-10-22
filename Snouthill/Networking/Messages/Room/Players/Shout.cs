using Snouthill.Game;

namespace Snouthill.Networking.Messages.Room.Players;

[Opcode(55)] // "SHOUT"
public record Shout(
    string Message) : IInboundMessage<Shout>
{
    public static Shout Deserialize(PacketReader reader)
    {
        var message = reader.ReadString();

        return new Shout(message);
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

        client.Player.Talk(TalkLevel.Shout, Message);
    }
}