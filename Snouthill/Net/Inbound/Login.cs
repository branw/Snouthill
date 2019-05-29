using Microsoft.EntityFrameworkCore;
using Serilog;
using Snouthill.Db;
using Snouthill.Net.Outbound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snouthill.Net.Inbound
{    
    class VersionCheck : InboundPacket, IPacketHandler
    {
        public override string Operation => "VERSIONCHECK";

        [Property] public string Version { get; set; }

        public void Handle(Client client)
        {
            if (Version != "client002")
            {
                Log.Warning("Unknown version {version}", Version);
            }

            client.Send(new EncryptionOff());
            client.Send(new SecretKey());
        }
    }

    class KeyEncrypted : InboundPacket
    {
        public override string Operation => "KEYENCRYPTED";

        [Property] public int Length { get; set; }
    }

    class ClientIP : InboundPacket
    {
        public override string Operation => "CLIENTIP";

        [Property] public string Data { get; set; }
    }

    class ApproveName : InboundPacket, IPacketHandler
    {
        public override string Operation => "APPROVENAME";

        [Property] public string Username { get; set; }

        public void Handle(Client client)
        {
            client.Send(new NameApproved());
        }
    }

    class Login : InboundPacket, IPacketHandler
    {
        public override string Operation => "LOGIN";

        [Property(suffix: " ")] public string Username { get; set; }
        [Property(suffix: " ")] public string Password { get; set; }
        [Property(optional: true)] public int? Door { get; set; }

        public void Handle(Client client)
        {
            Log.Information("Logging in {username}", Username);

            if (!client.Authenticated)
            {
                if (!client.Authenticate(Username, Password))
                {
                    client.Send(new SystemBroadcast("Incorrect username or password"));
                    return;
                }

                // Connecting to a public room
                if (Door == 0)
                {

                }

                // If we just authenticated with the main server, kill all other connections
                if (client.IsMainConnection)
                {
                    foreach(var otherClient in client.OtherClientsForUser)
                    {
                        otherClient.Connection.Disconnect();
                    }
                }
                // If we're a public or private room connection, kill all other room connections
                else
                {
                    foreach(var otherClient in client.OtherClientsForUser)
                    {
                        if (otherClient.IsPublicRoomConnection || otherClient.IsPrivateRoomConnection)
                        {
                            otherClient.Connection.Disconnect();
                        }
                    }
                }
            }
            
        }
    }

    class Update : InboundPacket, IPacketHandler
    {
        public override string Operation => "UPDATE";

        [Property(prefix: "name=", suffix: "\r")] public string Username { get; set; }
        [Property(prefix: "password=", suffix: "\r")] public string Password { get; set; }
        [Property(prefix: "email=", suffix: "\r")] public string Email { get; set; }
        [Property(prefix: "figure=", suffix: "\r")] public string Figure { get; set; }
        [Property(prefix: "directMail=", suffix: "\r")] public int DirectMail { get; set; }
        [Property(prefix: "birthday=", suffix: "\r")] public string Birthday { get; set; }
        [Property(prefix: "phonenumber=", suffix: "\r")] public string PhoneNumber { get; set; }
        [Property(prefix: "customData=", suffix: "\r")] public string Motto { get; set; }
        [Property(prefix: "has_read_agreement=", suffix: "\r")] public int HasReadAgreement { get; set; }
        [Property(prefix: "sex=", suffix: "\r")] public string Sex { get; set; }
        [Property(prefix: "country=")] public string Country { get; set; }

        public void Handle(Client client)
        {
            if (!client.Authenticated)
            {
                return;
            }

            Log.Information("Updating {username}", Username);

            using (var db = new DatabaseContext())
            {
                client.User.Password = Password;
                client.User.Email = Email;
                client.User.Figure = Figure;
                client.User.Birthday = Birthday;
                client.User.PhoneNumber = PhoneNumber;
                client.User.Motto = Motto;
                client.User.Sex = Sex;
                client.User.Country = Country;

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    Log.Warning(e, "Failed to update user");
                }
            }
        }
    }

    class Register : InboundPacket, IPacketHandler
    {
        public override string Operation => "REGISTER";

        [Property(prefix: "name=", suffix: "\r")] public string Username { get; set; }
        [Property(prefix: "password=", suffix: "\r")] public string Password { get; set; }
        [Property(prefix: "email=", suffix: "\r")] public string Email { get; set; }
        [Property(prefix: "figure=", suffix: "\r")] public string Figure { get; set; }
        [Property(prefix: "directMail=", suffix: "\r")] public int DirectMail { get; set; }
        [Property(prefix: "birthday=", suffix: "\r")] public string Birthday { get; set; }
        [Property(prefix: "phonenumber=", suffix: "\r")] public string PhoneNumber { get; set; }
        [Property(prefix: "customData=", suffix: "\r")] public string Motto { get; set; }
        [Property(prefix: "has_read_agreement=", suffix: "\r")] public int HasReadAgreement { get; set; }
        [Property(prefix: "sex=", suffix: "\r")] public string Sex { get; set; }
        [Property(prefix: "country=")] public string Country { get; set; }

        public void Handle(Client client)
        {
            Log.Information("Registering {username}", Username);

            using (var db = new DatabaseContext())
            {
                db.Users.Add(new User()
                {
                    Username = Username,
                    Password = Password,
                    Email = Email,
                    Figure = Figure,
                    Birthday = Birthday,
                    PhoneNumber = PhoneNumber,
                    Motto = Motto,
                    Sex = Sex,
                    Country = Country
                });

                try
                {
                    db.SaveChanges();
                }
                catch (DbUpdateException e)
                {
                    Log.Warning(e, "Failed to register user");
                    client.Send(new SystemBroadcast("Registration failed"));
                }
            }
        }
    }

    class FindUser : InboundPacket
    {
        public override string Operation => "FINDUSER";

        [Property] public string Username { get; set; }
    }

    class MessengerInit : InboundPacket
    {
        public override string Operation => "MESSENGERINIT";
    }

    class UniqueMachineId : InboundPacket
    {
        public override string Operation => "UNIQUEMACHINEID";

        [Property] public string Id { get; set; }
    }

    class Stat : InboundPacket
    {
        public override string Operation => "STAT";

        [Property] public string ShockwaveVersion { get; set; }
    }

    class HabboRep : InboundPacket
    {
        public override string Operation => "HABBOREP";

        [Property] public string ServerId { get; set; }
    }

    class InfoRetrieve : InboundPacket, IPacketHandler
    {
        public override string Operation => "INFORETRIEVE";

        [Property(suffix: " ")] public string Username { get; set; }
        [Property] public string Password { get; set; }

        public void Handle(Client client)
        {
            if (!client.Authenticated)
            {
                return;
            }

            if (client.User.Username != Username || client.User.Password != Password)
            {
                Log.Warning("Username or password ({username}, {password}) of INFORETRIEVE do not match current user ({username}, {password})",
                    Username, Password, client.User.Username, client.User.Password);
            }

            client.Send(new UserObject()
            {
                Username = client.User.Username,
                Figure = client.User.Figure,
                Email = client.User.Email,
                Birthday = client.User.Birthday,
                PhoneNumber = client.User.PhoneNumber,
                Motto = client.User.Motto,
                Sex = client.User.Sex,
                Country = client.User.Country,
                HasSpecialRights = client.User.Superuser ? 1 : 0,
                BadgeType = client.User.Badge
            });
        }
    }

    class GetAdForMe : InboundPacket
    {
        public override string Operation => "GETADFORME";

        [Property] public string Unk { get; set; }
    }

    class InitUnitListener : InboundPacket, IPacketHandler
    {
        public override string Operation => "INITUNITLISTENER";

        public void Handle(Client client)
        {
            client.Send(new AllUnits(client.Game.RoomManager.GetPublicRooms()));
        }
    }

    class GetCredits : InboundPacket, IPacketHandler
    {
        public override string Operation => "GETCREDITS";

        public void Handle(Client client)
        {
            if (!client.Authenticated)
            {
                return;
            }

            client.Send(new WalletBalance()
            {
                Credits = client.User.Credits
            });
        }
    }

    class GetProfile : InboundPacket
    {
        public override string Operation => "UINFO_GETPROFILE";
    }

    class AssignPersonalMessage : InboundPacket
    {
        public override string Operation => "MESSENGER_ASSIGNPERSMSG";

        [Property] public string Message { get; set; }
    }
}
