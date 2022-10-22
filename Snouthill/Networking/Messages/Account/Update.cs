using Serilog;
using Snouthill.Database;

namespace Snouthill.Networking.Messages.Account;

[Opcode(44)] // "UPDATE"
public record UpdateRequest(
    string? Figure,
    string? Motto,
    string? Sex,
    bool? ReceiveNews) : IInboundMessage<UpdateRequest>
{
    public static UpdateRequest Deserialize(PacketReader reader)
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
                    Log.Information("Unhandled Update case {Index}", updateId);
                    break;
            }
        }

        return new UpdateRequest(
            figure,
            motto,
            sex,
            receiveNews);
    }

    public void Handle(Client client)
    {
        if (client.Player == null)
            throw new PlayerNotAuthenticatedException();
        
        using var db = new DatabaseContext();
        var model = db.Players.Find(client.Player.Model.PlayerId);
        if (model == null)
            throw new InvalidOperationException();
        
        if (Figure != null)
            model.Figure = Figure;
        
        if (Motto != null)
            model.Motto = Motto;

        if (Sex != null)
        {
            if (Sex is not ("M" or "F"))
                throw new InvalidDataException($"Invalid sex {Sex}");
            
            model.Sex = Sex;
        }

        db.SaveChanges();
    }
}