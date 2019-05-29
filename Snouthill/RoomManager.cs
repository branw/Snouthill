using Snouthill.Db;
using Snouthill.Net;
using Snouthill.Net.Outbound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snouthill
{
    /*
    public class Furni
    {
        public int Id { get; }

    }

    public class OccupantStatus
    {
        public string Status { get; }
        public string Value { get; set; }
        public int? Duration { get; set; }

        public bool IsInfinite => Duration == null;

        public OccupantStatus(string status, string value = null, int? duration = null)
        {
            Status = status;
            Value = value;
            Duration = duration;
        }
    }

    public class Occupant
    {
        public Client Client { get; }
        public Room Room { get; }

        public (int X, int Y, int Z, int Direction) Position { get; set; }

        public IEnumerable<OccupantStatus> Statuses => _statuses;
        private List<OccupantStatus> _statuses;

        public Occupant(Client client, Room room)
        {
            Client = client;
            Room = room;

            _statuses = new List<OccupantStatus>();
        }
    }

    public class Room
    {
        public Db.Room Info { get; set; }

        public IEnumerable<Occupant> Occupants => _occupants;
        private List<Occupant> _occupants;

        public IEnumerable<Furni> Furni => _furni;
        private List<Furni> _furni;

        public Room(Db.Room roomInfo)
        {
            Info = roomInfo;

            _occupants = new List<Occupant>();
            _furni = new List<Furni>();

            //TODO load furni for public rooms
        }

        public void LoadForClient(Client client, (int X, int Y, int Z, int Direction) door)
        {
            var occupant = new Occupant(client, this);
            occupant.Position = door;

            client.Occupant = occupant;

            if (!_occupants.Any())
            {
                //TODO start room events


            }
            else
            {
                //TODO notify other users
            }

            client.Send(new HeightMap(Info.Model.HeightMap));
            client.Send(new Objects(Info.ModelName, Furni));

            //TODO ACTIVE_OBJECTS, ITEMS, USERS, STATUS
        }

        public void Send(OutboundPacket packet)
        {
            foreach(var occupant in Occupants)
            {
                occupant.Client.Send(packet);
            }
        }
    }

    public class RoomManager
    {
        public Game Game { get; }

        public IEnumerable<Room> Rooms => _rooms;
        private List<Room> _rooms;

        public RoomManager(Game game)
        {
            Game = game;

            _rooms = new List<Room>();

            using (var db = new DatabaseContext())
            {
                var publicRooms = db.Rooms.Where(r => r.IsPublic);
                foreach(var roomInfo in publicRooms)
                {
                    // Explicitly load model info
                    db.Entry(roomInfo).Reference(r => r.Model).Load();

                    _rooms.Add(new Room(roomInfo));
                }
            }
        }

        public IEnumerable<Room> GetPublicRooms()
        {
            return Rooms.Where(r => r.Info.IsPublic);   
        }
    }
    */
}
