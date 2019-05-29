using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Snouthill.Db.Models
{
    class PlacedFurniModel
    {
        public int FurniId { get; set; }
        [ForeignKey("FurniId")]
        public FurniDefinitionModel Furni { get; set; }

        public (int X, int Y, int Z, int Direction) Position { get; set; }

        public string Key { get; set; } = null;
        public string Value { get; set; } = null;
    }

    abstract class RoomModel
    {
        [Key] public int Id { get; set; }
        public abstract bool IsPublic { get; }

        public string Name { get; set; }

        public int MaxOccupancy { get; set; }
        
        public string FloorPlanName { get; set; }
        [ForeignKey("FloorPlanName")]
        public FloorPlanModel FloorPlan { get; set; }

        public List<PlacedFurniModel> Furnis { get; set; }
    }

    class PublicRoomModel : RoomModel
    {
        public override bool IsPublic => true;

        public List<PublicRoomConnectionModel> Connections { get; set; }
    }

    class PublicRoomConnectionModel
    {
        public int ToRoomId { get; set; }
        [ForeignKey("ToRoomId")]
        public PublicRoomModel ToRoom { get; set; }

        public List<(int X, int Y)> Entrances { get; set; }

        public (int X, int Y, int Z, int Orientation) Exit { get; set; }
    }

    class PrivateRoomModel : RoomModel
    {
        public override bool IsPublic => false;

        public int OwnerId { get; set; }
        [ForeignKey("OwnerId")]
        public UserModel Owner { get; set; }

        public bool ShowOwner { get; set; } = true;

        public List<UserModel> UsersWithRights { get; set; }

        public string Description { get; set; }
        public string Password { get; set; }

        public string Wallpaper { get; set; } = "0";
        public string Floor { get; set; } = "0";
    }
}
