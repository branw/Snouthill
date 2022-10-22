using System.Collections.Concurrent;
using Serilog;
using Snouthill.Game;

namespace Snouthill.Networking.Messages.Moderation;

[Opcode(237)] // "GET_PENDING_CALLS_FOR_HELP"
public record GetPendingCallsForHelp : IInboundMessage<GetPendingCallsForHelp>
{
    public static GetPendingCallsForHelp Deserialize(PacketReader reader) => new();

    public void Handle(Client client)
    {
        if (client.Player == null)
            throw new PlayerNotAuthenticatedException();
        
        var call = CallForHelpManager.GetPendingCallForPlayer(client.Player);
        client.Send(new PendingCallsForHelp(call));
    }
}