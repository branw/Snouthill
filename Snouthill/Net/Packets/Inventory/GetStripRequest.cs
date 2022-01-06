using Serilog;
using Snouthill.Game;

namespace Snouthill.Net.Packets.Inventory;

[RequestOpcode(65)]
public record GetStripRequest(
    string Action) : IRequest;

public class GetStripRequestDeserializer : IRequestDeserializer<GetStripRequest>
{
    public GetStripRequest Deserialize(PacketReader reader)
    {
        var action = reader.ReadRawString();

        return new GetStripRequest(action);
    }
}

public class GetStripRequestHandler : IRequestHandler<GetStripRequest>
{
    public void Handle(GetStripRequest request, Player player)
    {
        switch (request.Action)
        {
            case "new":
            {
                break;
            }

            case "next":
            {
                break;
            }

            case "prev":
            {
                break;
            }

            case "last":
            {
                break;
            }

            case "update":
            {
                break;
            }

            default:
                Log.Warning("Unknown strip view action {action}", request.Action);
                break;
        }
    }
}