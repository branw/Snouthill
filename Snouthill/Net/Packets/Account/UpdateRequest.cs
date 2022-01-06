using Serilog;

namespace Snouthill.Net.Packets.Account;

[RequestOpcode(44)]
public record UpdateRequest(
    string? Figure,
    string? Motto,
    string? Sex,
    bool? ReceiveNews) : IRequest;

public class UpdateRequestDeserialize : IRequestDeserializer<UpdateRequest>
{
    public UpdateRequest Deserialize(PacketReader reader)
    {
        string? figure = null;
        string? sex = null;
        string? motto = null;
        bool? receiveNews = null;

        while (reader.Remaining > 0)
        {
            var updateId = reader.ReadBase64Short();

            switch (updateId)
            {
                case 4:
                {
                    figure = reader.ReadString();
                    break;
                }

                case 5:
                {
                    sex = reader.ReadString();
                    break;
                }

                case 6:
                {
                    motto = reader.ReadString();
                    break;
                }

                case 9:
                {
                    receiveNews = reader.ReadBytes(1)[0] == 'A';
                    break;
                }

                default:
                    Log.Information("Unhandled Update case {index}", updateId);
                    break;
            }
        }

        return new UpdateRequest(
            figure,
            motto,
            sex,
            receiveNews);
    }
}