using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Snouthill.Db.Models
{
    class FurniDefinitionModel
    {
        [Key] public int Id { get; set; }

        public string Sprite { get; set; }
        public string Color { get; set; }

        public (int Length, int Width, double Height) Volume { get; set; }

        public FurniType DataType { get; set; }

        public FurniTrait Traits { get; set; }
    }

    enum FurniType
    {
        Regular,
        // For lamps
        SwitchOn,
        // For doors and gates
        Status,
        // For teleporters, ICMs, minibars, sinks
        DoorOpen,
        // For TVs, fireplaces
        FireOn,
        // For spinning bottle
        Dir,
        // For gifts
        Custom,
        // For dice
        Value,
        // For scoreboard
        Scoreboard
    }

    [Flags]
    enum FurniTrait
    {

    }
}
