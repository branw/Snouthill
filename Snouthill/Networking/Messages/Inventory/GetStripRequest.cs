using Serilog;

namespace Snouthill.Networking.Messages.Inventory;

[Opcode(65)] // "GETSTRIP"
public record GetStripRequest(
    string Action) : IInboundMessage<GetStripRequest>
{
    public static GetStripRequest Deserialize(PacketReader reader)
    {
        var action = reader.ReadRawString();

        return new GetStripRequest(action);
    }

    public void Handle(Client client)
    {
        switch (Action)
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
                Log.Warning("Unknown strip view action {Action}", Action);
                break;
        }
    }
}