using Microsoft.EntityFrameworkCore;
using Serilog;
using Snouthill.Db;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Snouthill.Net
{

    public class Client
    {
        public Game Game { get; }
        public Server Server { get; }

        public ClientConnection Connection { get; }
        public bool IsMainConnection => Connection?.Port == Config.Instance.MainPort;
        public bool IsPublicRoomConnection => Connection?.Port > Config.Instance.MainPort;
        public bool IsPrivateRoomConnection => Connection?.Port == Config.Instance.PrivateRoomPort;

        public IEnumerable<Client> OtherClientsForUser => 
            Server.Clients.Where(c => c != this && c.Authenticated && c.User.Username == User.Username);

        public Db.User User { get; internal set; }
        public bool Authenticated => User != null;

        public Occupant Occupant { get; set; }

        public Client(Server server, Socket socket)
        {
            Game = server.Game;
            Server = server;

            Connection = new ClientConnection(socket);
            Connection.PacketReceived += ReceiveRaw;
        }

        public void Send(OutboundPacket packet)
        {
            Log.Verbose("Sending {rawPacket}", packet.Raw);
            Log.Debug("<- {packet}", packet);

            Connection?.Send(Encoding.ASCII.GetBytes(packet.Raw));
        }

        public void ReceiveRaw(byte[] rawPacket)
        {
            var str = Encoding.ASCII.GetString(rawPacket);
            Log.Verbose("Received {rawPacket}", str);

            var packet = Packet.Parse(str);
            if (packet == null)
            {
                Log.Warning("Unknown packet {rawPacket}", str);
                return;
            }

            Log.Debug("-> {packet}", packet);

            if (typeof(IPacketHandler).IsAssignableFrom(packet.GetType()))
            {
                try
                {
                    ((IPacketHandler)packet).Handle(this);
                }
                catch (Exception e)
                {
                    Log.Error(e, "Exception thrown while handling packet {packet}", packet);
                    Connection.Disconnect();
                }
            }
        }

        public bool Authenticate(string username, string password)
        {
            using (var db = new Database())
            {
                var user = db.Users.SingleOrDefault(p => p.Username == username);

                if (user != null && user.Password == password)
                {
                    User = user;
                    return true;
                }

                return false;
            }
        }
    }
}
