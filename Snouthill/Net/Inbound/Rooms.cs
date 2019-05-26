using System;
using System.Collections.Generic;
using System.Text;

namespace Snouthill.Net.Inbound
{
    class GetUnitUsers : InboundPacket
    {
        public override string Operation => "GETUNITUSERS";

        [Property(prefix: "/")] public string RoomName { get; set; }
    }

    class SearchBusyFlats : InboundPacket
    {
        public override string Operation => "SEARCHBUSYFLATS";

        [Property(prefix: "/", suffix: ",")] public int Unk1 { get; set; }
        [Property] public int Unk2 { get; set; }
    }

    class Move : InboundPacket
    {
        public override string Operation => "Move";

        [Property(suffix: " ")] public int X { get; set; }
        [Property] public int Y { get; set; }
    }
    
    class CreateFlat : InboundPacket
    {
        public override string Operation => "CREATEFLAT";
        [Property(delim: "/")] public string Floor { get; set; }
        [Property(delim: "/")] public string Name { get; set; }
        [Property(delim: "/")] public string Model { get; set; }
        [Property(delim: "/")] public string State { get; set; }
        [Property(prefix: "/")] public int ShowOwnerName { get; set; }
    }
}
