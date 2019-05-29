using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Snouthill.Db.Models
{
    class BotModel
    {
        [Key] public int Id { get; set; }
        public int RoomId { get; set; }
        [ForeignKey("RoomId")]
        public RoomModel Room { get; set; }

        public string Name { get; set; }
        public string Motto { get; set; }
        public string Figure { get; set; }

        public (int X, int Y, int Z, int Direction) Spawn { get; set; }
        public List<(int X, int Y)> Positions { get; set; }
    }
}
