using Serilog;
using Snouthill.Db;
using Snouthill.Db.Models;
using Snouthill.Game;

namespace Snouthill.Net.Packets.Registration;

[RequestOpcode(43)]
public record Register(
    bool? ParentAgree,
    string? Name,
    string? Password,
    string? Figure,
    string? Sex,
    string? CustomData,
    string? Email,
    string? Birthday,
    bool? DirectMail,
    bool? HasReadAgreement,
    string? IspId,
    string? PartnerSite,
    string? OldPassword
) : IRequest;

public class RegisterDeserializer : IRequestDeserializer<Register>
{
    public Register Deserialize(PacketReader reader)
    {
        bool? parentAgree = null;
        string? name = null;
        string? password = null;
        string? figure = null;
        string? sex = null;
        string? customData = null;
        string? email = null;
        string? birthday = null;
        bool? directMail = null;
        bool? hasReadAgreement = null;
        string? ispId = null;
        string? partnerSite = null;
        string? oldPassword = null;

        while (reader.Remaining > 0)
        {
            var key = reader.ReadBase64Short();

            switch (key)
            {
                case 1:
                    parentAgree = reader.ReadBytes(1)[0] == 'A';
                    break;
                case 2:
                    name = reader.ReadString();
                    break;
                case 3:
                    password = reader.ReadString();
                    break;
                case 4:
                    figure = reader.ReadString();
                    break;
                case 5:
                    sex = reader.ReadString();
                    break;
                case 6:
                    customData = reader.ReadString();
                    break;
                case 7:
                    email = reader.ReadString();
                    break;
                case 8:
                    birthday = reader.ReadString();
                    break;
                case 9:
                    directMail = reader.ReadBytes(1)[0] == 'A';
                    break;
                case 10:
                    hasReadAgreement = reader.ReadBytes(1)[0] == 'A';
                    break;
                case 11:
                    ispId = reader.ReadString();
                    break;
                case 12:
                    partnerSite = reader.ReadString();
                    break;
                case 13:
                    oldPassword = reader.ReadString();
                    break;
                default:
                    Log.Warning("Unknown registration value with key {key}", key);
                    break;
            }
        }

        return new Register(
            parentAgree,
            name,
            password,
            figure,
            sex,
            customData,
            email,
            birthday,
            directMail,
            hasReadAgreement,
            ispId,
            partnerSite,
            oldPassword);
    }
}

public class RegisterHandler : IRequestHandler<Register>
{
    public void Handle(Register request, Player player)
    {
        using (var db = new DatabaseContext())
        {
            db.Players.Add(
                new PlayerModel
                {
                    Name = request.Name,
                    Password = request.Password,
                    Email = request.Email,
                    Birthday = request.Birthday,
                    Sex = request.Sex,
                    Figure = request.Figure
                });
            db.SaveChanges();
        }

        player.Name = request.Name;

        Log.Information("Registered {username}", request.Name);
    }
}