using Snouthill.Game;

namespace Snouthill.Net.Packets.Registration;

[RequestOpcode(49)] // "GDATE"
public record DateRequest : IRequest;

public class DateRequestHandler : IRequestHandler<DateRequest>
{
    public void Handle(DateRequest request, Player player)
    {
        player.Send(new DateResponse(DateTime.Now.ToShortDateString()));
    }
}