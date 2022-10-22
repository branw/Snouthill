using Snouthill.Game;

namespace Snouthill.Networking.Messages.Moderation;

[Opcode(86)] // "CRYFORHELP"
public record SubmitCallForHelp(
    string Message) : IInboundMessage<SubmitCallForHelp>
{
    public static SubmitCallForHelp Deserialize(PacketReader reader)
    {
        var message = reader.ReadString();

        return new SubmitCallForHelp(message);
    }

    public void Handle(Client client)
    {
        if (client.Player == null)
            throw new PlayerNotAuthenticatedException();
        if (client.Player.Room == null)
            throw new PlayerNotInRoomException();

        CallForHelpManager.SubmitCall(client.Player, Message);
    }
}