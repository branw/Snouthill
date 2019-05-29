using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snouthill.Net.Outbound
{
    class AllUnits : OutboundPacket
    {
        public override string Operation => "ALLUNITS";

        public class Unit : PacketComponent
        {
            public class SubUnit : PacketComponent
            {
                [Property(suffix: ",")] public string FileName { get; set; }
                [Property(suffix: ",")] public int CurrentOccupancy { get; set; }
                [Property(suffix: ",")] public int MaxOccupancy { get; set; }
                [Property] public string ModelName { get; set; }

                public SubUnit(string fileName, int currentOccupancy, int maxOccupancy, string modelName)
                {
                    FileName = fileName;
                    CurrentOccupancy = currentOccupancy;
                    MaxOccupancy = maxOccupancy;
                    ModelName = modelName;
                }
            }

            [Property(suffix: ",")] public string Name { get; set; }
            [Property(suffix: ",")] public int CurrentOccupancy { get; set; }
            [Property(suffix: ",")] public int MaxOccupancy { get; set; }
            [Property(suffix: "/")] public string Ip { get; set; }
            [Property(suffix: ",")] public string Ip2 => Ip;
            [Property(suffix: ",")] public int Port { get; set; }
            [Property] public string Name2 => Name;
            [Property(prefix: "\t")] public IEnumerable<SubUnit> SubUnits { get; set; }

            public Unit(string name, int currentOccupancy, int maxOccupancy, string ip, int port, IEnumerable<(string fileName, int currentOccupancy, int maxOccupancy, string modelName)> subunits)
            {
                Name = name;
                CurrentOccupancy = currentOccupancy;
                MaxOccupancy = maxOccupancy;
                Ip = ip;
                Port = port;
                SubUnits = subunits.Select(su => new SubUnit(su.fileName, su.currentOccupancy, su.maxOccupancy, su.modelName));
            }
        }

        [Property(prefix: "\r")] public IEnumerable<Unit> Units { get; set; }

        public AllUnits(IEnumerable<Room> rooms)
        {
            var units = new List<Unit>();

            foreach(var room in rooms)
            {
                var subunit = (room.Info.Model.FileName, 0, room.Info.MaxOccupancy, room.Info.Model.ModelName);
                units.Add(new Unit(room.Info.Name, 0, room.Info.MaxOccupancy, "127.0.0.1",
                    ServerConfig.Instance.MainPort + room.Info.Id, new List<(string, int, int, string)>() { subunit }));
            }

            Units = units;
        }
    }

    class HeightMap : OutboundPacket
    {
        public override string Operation => "HEIGHTMAP";

        [Property(prefix: "\r")] public string Data { get; set; }

        public HeightMap(string heightMap)
        {
            Data = heightMap;
        }
    }

    class Objects : OutboundPacket
    {
        public override string Operation => "OBJECTS";

        public class PassiveObject : PacketComponent
        {

        }

        [Property(prefix: " WORLD 0 ")] public string ModelName { get; set; }
        [Property(prefix: "\r")] public IEnumerable<PassiveObject> PassiveObjects { get; set; }

        public Objects(string modelName, IEnumerable<Furni> passiveObjects)
        {
            ModelName = modelName;

            var objects = new List<PassiveObject>();
            foreach(var passiveObject in passiveObjects)
            {

            }
            PassiveObjects = objects;
        }
    }
}
