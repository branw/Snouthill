using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Snouthill.Db
{
    public class User
    {
        [Key] public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }
        public string PhoneNumber { get; set; }
        public string Motto { get; set; }
        public string Sex { get; set; }
        public string Country { get; set; }
        public string Figure { get; set; }

        public bool Superuser { get; set; } = false;
        public string Badge { get; set; }
        public int Credits { get; set; } = 0;
    }

    public class Room { 
        [Key] public int Id { get; set; }
        public bool IsPublic { get; set; }
        public User Owner { get; set; } = null;
        public bool ShowOwner { get; set; } = false;
        public string Name { get; set; }
        public string Description { get; set; } = null;
        public string Password { get; set; } = null;
        public int MaxOccupancy { get; set; }
        public string ModelName { get; set; }
        [ForeignKey("ModelName")]
        public RoomModel Model { get; set; }
        public string Wallpaper { get; set; } = "0";
        public string Floor { get; set; } = "0";
    }

    public class RoomModel
    {
        [Key] public string ModelName { get; set; }
        public string FileName { get; set; }
        public int DoorX { get; set; }
        public int DoorY { get; set; }
        public int DoorZ { get; set; }
        public int DoorDirection { get; set; }
        public string HeightMap { get; set; }
        public bool HasPool { get; set; }
        public bool DisableHeightCheck { get; set; }
    }

    public class Database : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<RoomModel> RoomModels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Setup properties
            modelBuilder.Entity<User>().HasAlternateKey(u => u.Username).HasName("AlternateKey_Username");
            modelBuilder.Entity<User>().Property(u => u.Superuser).HasDefaultValue(false);

            modelBuilder.Entity<RoomModel>().HasAlternateKey(u => u.ModelName).HasName("AlternateKey_ModelName");

            // Seed the database when creating from empty
            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "model_a", DoorX = 3, DoorY = 5, DoorZ = 0, DoorDirection = 2, HeightMap = "xxxxxxxxxxxx xxxx00000000 xxxx00000000 xxxx00000000 xxxx00000000 xxxx00000000 xxxx00000000 xxxx00000000 xxxx00000000 xxxx00000000 xxxx00000000 xxxx00000000 xxxx00000000 xxxx00000000 xxxxxxxxxxxx xxxxxxxxxxxx", HasPool = false, DisableHeightCheck = false});
            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "model_b", DoorX = 0, DoorY = 5, DoorZ = 0, DoorDirection = 2, HeightMap = "xxxxxxxxxxxx xxxxx0000000 xxxxx0000000 xxxxx0000000 xxxxx0000000 x00000000000 x00000000000 x00000000000 x00000000000 x00000000000 x00000000000 xxxxxxxxxxxx xxxxxxxxxxxx xxxxxxxxxxxx xxxxxxxxxxxx xxxxxxxxxxxx", HasPool = false, DisableHeightCheck = false});
            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "model_c", DoorX = 4, DoorY = 7, DoorZ = 0, DoorDirection = 2, HeightMap = "xxxxxxxxxxxx xxxxxxxxxxxx xxxxxxxxxxxx xxxxxxxxxxxx xxxxxxxxxxxx xxxxx000000x xxxxx000000x xxxxx000000x xxxxx000000x xxxxx000000x xxxxx000000x xxxxxxxxxxxx xxxxxxxxxxxx xxxxxxxxxxxx xxxxxxxxxxxx xxxxxxxxxxxx", HasPool = false, DisableHeightCheck = false});
            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "model_d", DoorX = 4, DoorY = 7, DoorZ = 0, DoorDirection = 2, HeightMap = "xxxxxxxxxxxx xxxxx000000x xxxxx000000x xxxxx000000x xxxxx000000x xxxxx000000x xxxxx000000x xxxxx000000x xxxxx000000x xxxxx000000x xxxxx000000x xxxxx000000x xxxxx000000x xxxxx000000x xxxxx000000x xxxxxxxxxxxx", HasPool = false, DisableHeightCheck = false});
            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "model_e", DoorX = 1, DoorY = 5, DoorZ = 0, DoorDirection = 2, HeightMap = "xxxxxxxxxxxx xxxxxxxxxxxx xxxxxxxxxxxx xx0000000000 xx0000000000 xx0000000000 xx0000000000 xx0000000000 xx0000000000 xx0000000000 xx0000000000 xxxxxxxxxxxx xxxxxxxxxxxx xxxxxxxxxxxx xxxxxxxxxxxx xxxxxxxxxxxx", HasPool = false, DisableHeightCheck = false});
            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "model_f", DoorX = 2, DoorY = 5, DoorZ = 0, DoorDirection = 2, HeightMap = "xxxxxxxxxxxx xxxxxxx0000x xxxxxxx0000x xxx00000000x xxx00000000x xxx00000000x xxx00000000x x0000000000x x0000000000x x0000000000x x0000000000x xxxxxxxxxxxx xxxxxxxxxxxx xxxxxxxxxxxx xxxxxxxxxxxx xxxxxxxxxxxx", HasPool = false, DisableHeightCheck = false});

            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "entryhall", FileName = "lobby", DoorX = 17, DoorY = 18, DoorZ = 1, DoorDirection = 0, HeightMap = "xx11xxxx11xxxx11xxxx x1111111111111111111 11111111111111111111 11111111111111111111 x1111111111111111111 x1111111111111111111 x1111111111111111111 x1111111111111111111 x1111111111111111111 x1111111111111111111 x1111111111111111111 x1111111111111111111 x1111111111111111111 x1111111111111111111 x1111111111111111111 x1111111111111111111 x1111111111111111111 x1111111111111111111 x1111111111111111111 x1111111111111111111 xxxxxxxxxxxxxxxxx11x", HasPool = false, DisableHeightCheck = false });
            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "lobby_a", FileName = "lobby", DoorX = 12, DoorY = 27, DoorZ = 0, DoorDirection = 0, HeightMap = "XXXXXXXXX77777777777XXXXX XXXXXXXXX777777777777XXXX XXXXXXXXX777777777766XXXX XXXXXXXXX777777777755XXXX XX333333333333333334433XX XX333333333333333333333XX XX333333333333333333333XX 33333333333333333333333XX 333333XXXXXXX3333333333XX 333333XXXXXXX2222222222XX 333333XXXXXXX2222222222XX XX3333XXXXXXX2222222222XX XX3333XXXXXXX222222221111 XX3333XXXXXXX111111111111 333333XXXXXXX111111111111 3333333222211111111111111 3333333222211111111111111 3333333222211111111111111 XX33333222211111111111111 XX33333222211111111111111 XX3333322221111111XXXXXXX XXXXXXX22221111111XXXXXXX XXXXXXX22221111111XXXXXXX XXXXXXX22221111111XXXXXXX XXXXXXX22221111111XXXXXXX XXXXXXX222X1111111XXXXXXX XXXXXXX222X1111111XXXXXXX XXXXXXXXXXXX11XXXXXXXXXXX XXXXXXXXXXXX11XXXXXXXXXXX XXXXXXXXXXXX11XXXXXXXXXXX XXXXXXXXXXXX11XXXXXXXXXXX", HasPool = false, DisableHeightCheck = false });
            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "floorlobby_a", FileName = "lobby", DoorX = 9, DoorY = 21, DoorZ = 0, DoorDirection = 0, HeightMap = "XXXXXXXXXXXXXXXXXXXXXXXXXXX XXXXXXXXXXXXXXXXXXXXXXXXXXX XXX0000000000000000XXXXXXX0 XXX000000000000000000XXXX00 X00000000000000000000000000 X00000000000000000000000000 XXX000000000000000000000000 XXXXXXX00000000000000000000 XXX111100000011111111111111 XXX111100000011111111111111 XXX111100000011111111111111 XXX111100000011111111111111 XXX111100000011111111111111 XXX111100000011111111111111 XXX1XX100000011111111111111 XXX1XX100000011111111111111 XXX111100000011111111111111 XXX111100000011111111111111 XXX111100000011111111111111 XXXXXXXX0000XXXXXXXXXXXXXXX XXXXXXXX0000XXXXXXXXXXXXXXX XXXXXXXX0000XXXXXXXXXXXXXXX", HasPool = false, DisableHeightCheck = false });
            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "floorlobby_b", FileName = "lobby", DoorX = 9, DoorY = 21, DoorZ = 0, DoorDirection = 0, HeightMap = "XXXXXXXXXXXXXXXXXXXXXXXXXXX XXXXXXXXXXXXXXXXXXXXXXXXXXX XXX0000000000000000XXXXXXX0 XXX000000000000000000XXXX00 X00000000000000000000000000 X00000000000000000000000000 XXX000000000000000000000000 XXXXXXX00000000000000000000 XXX111100000011111111111111 XXX111100000011111111111111 XXX111100000011111111111111 XXX111100000011111111111111 XXX111100000011111111111111 XXX111100000011111111111111 XXX1XX100000011111111111111 XXX1XX100000011111111111111 XXX111100000011111111111111 XXX111100000011111111111111 XXX111100000011111111111111 XXXXXXXX0000XXXXXXXXXXXXXXX XXXXXXXX0000XXXXXXXXXXXXXXX XXXXXXXX0000XXXXXXXXXXXXXXX", HasPool = false, DisableHeightCheck = false});
            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "floorlobby_c", FileName = "lobby", DoorX = 9, DoorY = 21, DoorZ = 0, DoorDirection = 0, HeightMap = "XXXXXXXXXXXXXXXXXXXXXXXXXXX XXXXXXXXXXXXXXXXXXXXXXXXXXX XXX0000000000000000XXXXXXX0 XXX000000000000000000XXXX00 X00000000000000000000000000 X00000000000000000000000000 XXX000000000000000000000000 XXXXXXX00000000000000000000 XXX111100000011111111111111 XXX111100000011111111111111 XXX111100000011111111111111 XXX111100000011111111111111 XXX111100000011111111111111 XXX111100000011111111111111 XXX1XX100000011111111111111 XXX1XX100000011111111111111 XXX111100000011111111111111 XXX111100000011111111111111 XXX111100000011111111111111 XXXXXXXX0000XXXXXXXXXXXXXXX XXXXXXXX0000XXXXXXXXXXXXXXX XXXXXXXX0000XXXXXXXXXXXXXXX", HasPool = false, DisableHeightCheck = false });

            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "pool_a", FileName = "lido", DoorX = 2, DoorY = 25, DoorZ = 7, DoorDirection = 2, HeightMap = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxx7xxxxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxx777xxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxx7777777xxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxx77777777xxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxx77777777xxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxx777777777xxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxx7xxx777777xxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxx7x777777777xxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxx7xxx77777777xxxxxxxxxxxxxxxx xxxxxxxxxxxxxxx7x777777777x7xxxxxxxxxxxxxxx xxxxxxxxxxxxxxx7xxx7777777777xxxxxxxxxxxxxx xxxxxxxxxxxxxxx777777777777xxxxxxxxxxxxxxxx xxxxxxxxxxxxxxx77777777777x2111xxxxxxxxxxxx xxxxxxxxxxxxxxx7777777777x221111xxxxxxxxxxx xxxxxxxxx7777777777777777x2211111xxxxxxxxxx xxxxxxxxx7777777777777777x22211111xxxxxxxxx xxxxxxxxx7777777777777777x222211111xxxxxxxx xxxxxx77777777777777777777x222211111xxxxxxx xxxxxx7777777xx777777777777x222211111xxxxxx xxxxxx7777777xx77777777777772222111111xxxxx xxxxxx777777777777777777777x22221111111xxxx xx7777777777777777777777x322222211111111xxx 77777777777777777777777x33222222111111111xx 7777777777777777777777x333222222211111111xx xx7777777777777777777x333322222222111111xxx xx7777777777777777777333332222222221111xxxx xx777xxx777777777777733333222222222211xxxxx xx777x7x77777777777773333322222222222xxxxxx xx777x7x7777777777777x33332222222222xxxxxxx xxx77x7x7777777777777xx333222222222xxxxxxxx xxxx77777777777777777xxx3222222222xxxxxxxxx xxxxx777777777777777777xx22222222xxxxxxxxxx xxxxxx777777777777777777x2222222xxxxxxxxxxx xxxxxxx777777777777777777222222xxxxxxxxxxxx xxxxxxxx7777777777777777722222xxxxxxxxxxxxx xxxxxxxxx77777777777777772222xxxxxxxxxxxxxx xxxxxxxxxx777777777777777222xxxxxxxxxxxxxxx xxxxxxxxxxx77777777777777x2xxxxxxxxxxxxxxxx xxxxxxxxxxxx77777777777777xxxxxxxxxxxxxxxxx xxxxxxxxxxxxx777777777777xxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxx7777777777xxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxx77777777xxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxx777777xxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxx7777xxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxx77xxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", HasPool = true, DisableHeightCheck = false });
            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "pool_b", FileName = "lido", DoorX = 9, DoorY = 21, DoorZ = 7, DoorDirection = 2, HeightMap = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx7xxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx777xxxxxxxxxxx xxxxxxxxxxxxxxxxxx8888888x7xxx77777xxxxxxxxxx xxxxxxxxxxxxxxxxxx8888888x7xxx777777xxxxxxxxx xxxxxxxxxxxxxxxx88xxxxx77x7x777777777xxxxxxxx xxxxxxxxxxxxxxxx88x7777777777777777777xxxxxxx xxxxxxxxxxxxxxxx88x77777777777777777777xxxxxx xxxxxxxxxxxxxx9988x77777777777777777777xxxxxx xxxxxxxxxxxxxx9988x7777777777777777777x00xxxx xxxxxxxxxxxxxx9988x777777777777777777x0000xxx xxxxxxxxxxxxxx9988x7777777x0000000000000000xx xxxxxxxxxxxxxx9988x777777x000000000000000000x 7777777777xxxx9988777777x0x0000000000000000xx x7777777777xxx998877777x000x00000000000000xxx xx7777777777xx99887777x00000x000000000000xxxx xxx7777777777x9988777x0000000x0000000000xxxxx xxxx777777777x777777x00000000x000000000xxxxxx xxxxx777777777777777000000000x00000000xxxxxxx xxxxxx77777777777777000000000x0000000xxxxxxxx xxxxxxx777777x7777770000000000xxxx00xxxxxxxxx xxxxxxxx77777777777xx0000000000000xxxxxxxxxxx xxxxxxxxx777777110000x000000000000xxxxxxxxxxx xxxxxxxxxx7x77x1100000x0000000000xxxxxxxxxxxx xxxxxxxxxxx777x11000000x00000000xxxxxxxxxxxxx xxxxxxxxxxxx771110000000x000000xxxxxxxxxxxxxx xxxxxxxxxxxxx111100000000x0000xxxxxxxxxxxxxxx xxxxxxxxxxxxxx11100000000x000xxxxxxxxxxxxxxxx xxxxxxxxxxxxxxx1100000000x00xxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxx110000000x0xxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxx110000000xxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxx1100000xxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxx11000xxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxx110xxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxx1xxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx", HasPool = true, DisableHeightCheck = false });

            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "bar_a", FileName = "club", DoorX = 5, DoorY = 1, DoorZ = 7, DoorDirection = 2, HeightMap = "xxxx8888xxxxxxxxxxx xxxx7777xxxxxxxxxxx xxxx6666xxxxxxxxxxx xxx6666666555555555 xxx6666666555555555 xxx6666666555555555 xxx6666666555555555 xxx6666666555555555 xxx6666666555555555 xxx6666666555555555 xxx6666666555xxxxxx xxx6666666555555555 xxx5555555555555555 xxx5555555555555555 xxx5555555555555555 xxx5555555555555555 xxx5555555555xxxxxx xxx5555555555555555 xxx5555555555555555 xxx5555555555555555 xxx5555555555555555 xxx5555555555555555 xxx5555555555xxxxxx xxxx555555555555555 55xx555555555555555 55xx555555555555555 5555555555555555555 5555555555555555555 xxxxxxxx55555xxxxxx xxxxxxxxx5555xxxxxx xxxxxxxxx5555xxxxxx xxxxxxxxx5555xxxxxx xxxxxxxxx4444xxxxxx xxxxxxxxx3333xxxxxx", HasPool = false, DisableHeightCheck = false });
            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "bar_b", FileName = "club", DoorX = 2, DoorY = 12, DoorZ = 4, DoorDirection = 2, HeightMap = "xxxxx4xxxxxxxxxxxx xxxx4444444xxxxxxx xxxx4444444xxxxxxx xxx444444444444444 xxx444444444444444 xxx444444444444444 xxx444444444444444 xxx444444444444444 xxx444444444444444 xxx444444444444444 654444444444444444 654444444444444444 654444444444444444 654444444444444444 xxx444444444444444 xxx444444444444444 xxx444444444444444 xxx444444444444444 xxx444444444444444 xxxx44444444444444 xxxx33444444444444 xxxx22444444444444 xxxx2222222222xx44 xxxx2222222222xx44 xxxxx222222222xxxx xxxxxx22222222xxxx xxxxxx22222222xxxx xxxxxx22222222xxxx xxxxxx22222222xxxx xxxxxx22222222xxxx xxxxxx22222222xxxx", HasPool = false, DisableHeightCheck = true });

            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "hallC", FileName = "gamehall", DoorX = 1, DoorY = 1, DoorZ = 1, DoorDirection = 4, HeightMap = "11xxxxxxxxxxxxxxx 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111", HasPool = false, DisableHeightCheck = false});
            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "hallA", FileName = "gamehall", DoorX = 1, DoorY = 1, DoorZ = 1, DoorDirection = 4, HeightMap = "11xxxxxxxxxxxxxxx 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111", HasPool = false, DisableHeightCheck = false});
            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "hallB", FileName = "gamehall", DoorX = 1, DoorY = 1, DoorZ = 1, DoorDirection = 4, HeightMap = "11xxxxxxxxxxxxxxx 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111", HasPool = false, DisableHeightCheck = false});
            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "hallD", FileName = "gamehall", DoorX = 1, DoorY = 1, DoorZ = 1, DoorDirection = 4, HeightMap = "11xxxxxxxxxxxxxxx 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111 11111111111111111", HasPool = false, DisableHeightCheck = false});

            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "malja_bar_b", FileName = "disco", DoorX = 5, DoorY = 24, DoorZ = 3, DoorDirection = 0, HeightMap = "6666333333333333 6666333333333333 6666333333333333 7766333333333333 7755333333333333 8855333333332223 8844333311111111 9944333311111111 9933333311111111 9933333311111111 9933333311111111 9933333311111111 9933333311111111 9933333311111111 9933333211111111 9933333211111111 9933333211111111 9933333311111111 99333333xxxxxxxx 99333333xxxxxxxx xxx33333xxxxxxxx xxx33333xxxxxxxx 3xx33333xxxxxxxx xxx33333xxxxxxxx xxx33333xxxxxxxx xxx33333xxxxxxxx", HasPool = false, DisableHeightCheck = false});
            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "malja_bar_a", FileName = "disco", DoorX = 4, DoorY = 24, DoorZ = 1, DoorDirection = 0, HeightMap = "xxxxxxxxxxx44444 xxxx444444444444 xxxx444444444444 xxxx444444444444 xxxx444444444444 xxxx444444444444 xxxxxxxxxxxxx333 1111111111111222 1111111111111111 1111111111111111 1111111111111111 1111111111111111 1111111111111111 1111111111111111 1111111111111111 1111111111111111 1111111111111111 1111111111111111 1111111111111111 111111111xxxxxxx xxx11111xxxxxxxx 11111111xxxxxxxx 11111111xxxxxxxx 11111111xxxxxxxx 11111111xxxxxxxx", HasPool = false, DisableHeightCheck = false});

            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "pub_a", FileName = "pub", DoorX = 15, DoorY = 25, DoorZ = 0, DoorDirection = 2, HeightMap = "xxxxxxxxxxxxxxxxxxxxxxxxx xxxxxxxxx2222222211111xxx xxxxxxxxx2222222211111xxx xxxxxxxxx2222222211111xxx xxxxxxxxx2222222211111xxx xxxxxxxxx2222222222111xxx xxxxxxxxx2222222222111xxx xxxxxxxxx2222222222000xxx xxxxxxxxx2222222222000xxx xxxxxxxxx2222222222000xxx xxxxxxxxx2222222222000xxx x333333332222222222000xxx x333333332222222222000xxx x333333332222222222000xxx x333333332222222222000xxx x333333332222222222000xxx x333332222222222222000xxx x333332222222222222000xxx x333332222222222222000xxx x333332222222222222000xxx x333333332222222222000xxx xxxxx31111112222222000xxx xxxxx31111111000000000xxx xxxxx31111111000000000xxx xxxxx31111111000000000xxx xxxxx31111111000000000xxx xxxxxxxxxxxxxxx00xxxxxxxx xxxxxxxxxxxxxxx00xxxxxxxx xxxxxxxxxxxxxxx00xxxxxxxx xxxxxxxxxxxxxxx00xxxxxxxx xxxxxxxxxxxxxxxxxxxxxxxxx", HasPool = false, DisableHeightCheck = false });
            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "theater", FileName = "theatredome", DoorX = 20, DoorY = 27, DoorZ = 0, DoorDirection = 2, HeightMap = "XXXXXXXXXXXXXXXXXXXXXXX XXXXXXXXXXXXXXXXXXXXXXX XXXXXXXXXXXXXXXXXXXXXXX XXXXXXXXXXXXXXXXXXXXXXX XXXXXXXXXXXXXXXXXXXXXXX XXXXXXXXXXXXXXXXXXXXXXX XXXXXXX111111111XXXXXXX XXXXXXX11111111100000XX XXXX00X11111111100000XX XXXX00x11111111100000XX 4XXX00X11111111100000XX 4440000XXXXXXXXX00000XX 444000000000000000000XX 4XX000000000000000000XX 4XX0000000000000000000X 44400000000000000000000 44400000000000000000000 44X0000000000000000O000 44X11111111111111111000 44X11111111111111111000 33X11111111111111111000 22X11111111111111111000 22X11111111111111111000 22X11111111111111111000 22X11111111111111111000 22X11111111111111111000 22211111111111111111000 22211111111111111111000 XXXXXXXXXXXXXXXXXXXX00X XXXXXXXXXXXXXXXXXXXX00X", HasPool = false, DisableHeightCheck = false });
            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "cr_kitchen", FileName = "kitchen", DoorX = 7, DoorY = 21, DoorZ = 0, DoorDirection = 2, HeightMap = "X0XXXX000XXXX000X0X X000000000000000000 X000000000000000000 X000000000000000XXX X00XXXX00XXXX000XXX X00XXXX00XXXX00XXXX X00000000000000XXXX X00000000000000XXXX X00000000000000XXXX X00XXXXXXXXXX00XXXX X00XXXXXXXXXX00XXXX X00XXXXXXXXXX000XXX 0000000000000000XXX 000000000000000XXXX 000000000000000XXXX 000XXX0000XXX00XXXX 000XXX0000XXX00XXXX 000000000000000XXXX 000000000000000XXXX 000000000000000XXXX XXXXXXX00XXXXXXXXXX XXXXXXX00XXXXXXXXXX XXXXXXX00XXXXXXXXXX", HasPool = false, DisableHeightCheck = false });
            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "taivas_cafe", FileName = "cafe", DoorX = 14, DoorY = 29, DoorZ = 0, DoorDirection = 2, HeightMap = "XXXXXXXXXXXXX111111X XXXXXXXXXXXXX1111111 XXXXXXXXXXXXX1111111 XXXXXXXXXXXXX1111111 XXXXXXXXXXXXX1111111 XXX11111111111111111 XXX11111111111111111 XX111111111111111111 XX111111111111111111 XX111111111111111111 XXX11111111111111111 111111111XXXXXXX1111 111111111X0000000000 111111111X0000000000 111111111X0000000000 111111111X0000000000 111111111X0000000000 111111111X0000000000 111111111X0000000000 111111111X0000000000 111111111X0000000000 X11111111X0000000000 XX1111111X0000000000 XXX111111X0000000000 XXXX11111X0000000000 XXXXX111110000000000 XXXXXX11110000000000 XXXXXXX1110000000000 XXXXXXXX11000000000X XXXXXXXXXX00000000XX XXXXXXXXXXXXXX00XXXX XXXXXXXXXXXXXX00XXXX", HasPool = false, DisableHeightCheck = false });
            modelBuilder.Entity<RoomModel>().HasData(new RoomModel() { ModelName = "habburger", FileName = "habburger", DoorX = 22, DoorY = 10, DoorZ = 0, DoorDirection = 6, HeightMap = "22222222222222222222xxx 22222222222222222222xxx 22222222222222222222xxx 22222222222222222222xxx xxxxxxxxxxxxxxxx1111xxx xxxxxxxxxxxxxxxx0000xxx xxx00000000000000000xxx 00000000000000000000xxx 00000000000000000000xxx 00000000000000000000000 00000000000000000000000 00000000000000000000xxx 00000000000000000000xxx 00000000000000000000xxx xxx00000000000000000xxx", HasPool = false, DisableHeightCheck = false });


            modelBuilder.Entity<Room>().HasData(new Room { Id = 12, IsPublic = true, Name = "Main Lobby", MaxOccupancy = 40, ModelName = "lobby_a" });

            /*
            modelBuilder.Entity<Room>().HasData(new Room() { Id = 12, IsPublic = true, Name = "Main Lobby", MaxOccupancy = 40, Model = new RoomModel() { ModelName = "lobby_a" } });
            modelBuilder.Entity<Room>().HasData(new Room() { Id = 13, IsPublic = true, Name = "Habbo Lido", MaxOccupancy = 40, Model = new RoomModel() { ModelName = "pool_a" } });
            modelBuilder.Entity<Room>().HasData(new Room() { Id = 14, IsPublic = true, Name = "The Dirty Duck Pub", MaxOccupancy = 40, Model = new RoomModel() { ModelName = "pub_a" } });
            modelBuilder.Entity<Room>().HasData(new Room() { Id = 16, IsPublic = true, Name = "Hotel Kitchen", MaxOccupancy = 25, Model = new RoomModel() { ModelName = "cr_kitchen" } });
            modelBuilder.Entity<Room>().HasData(new Room() { Id = 17, IsPublic = true, Name = "Cafe Ole", MaxOccupancy = 40, Model = new RoomModel() { ModelName = "taivas_cafe" } });
            modelBuilder.Entity<Room>().HasData(new Room() { Id = 19, IsPublic = true, Name = "Habburger's", MaxOccupancy = 40, Model = new RoomModel() { ModelName = "habburger" } });
            modelBuilder.Entity<Room>().HasData(new Room() { Id = 21, IsPublic = true, Name = "Habbo Lido II", MaxOccupancy = 30, Model = new RoomModel() { ModelName = "pool_b" } });
            modelBuilder.Entity<Room>().HasData(new Room() { Id = 22, IsPublic = true, Name = "Club Massiva", MaxOccupancy = 40, Model = new RoomModel() { ModelName = "bar_a" } });
            modelBuilder.Entity<Room>().HasData(new Room() { Id = 24, IsPublic = true, Name = "Theatredrome", MaxOccupancy = 25, Model = new RoomModel() { ModelName = "theater" } });
            modelBuilder.Entity<Room>().HasData(new Room() { Id = 25, IsPublic = true, Name = "Basement Lobby", MaxOccupancy = 35, Model = new RoomModel() { ModelName = "floorlobby_a" } });
            modelBuilder.Entity<Room>().HasData(new Room() { Id = 26, IsPublic = true, Name = "Median Lobby", MaxOccupancy = 40, Model = new RoomModel() { ModelName = "floorlobby_b" } });
            modelBuilder.Entity<Room>().HasData(new Room() { Id = 27, IsPublic = true, Name = "Skylight Lobby", MaxOccupancy = 40, Model = new RoomModel() { ModelName = "floorlobby_c" } });
            modelBuilder.Entity<Room>().HasData(new Room() { Id = 29, IsPublic = true, Name = "Club Massiva (downstairs)", MaxOccupancy = 40, Model = new RoomModel() { ModelName = "bar_b" } });
            modelBuilder.Entity<Room>().HasData(new Room() { Id = 30, IsPublic = true, Name = "Cunning Fox Gamehall", MaxOccupancy = 40, Model = new RoomModel() { ModelName = "entryhall" } });
            modelBuilder.Entity<Room>().HasData(new Room() { Id = 31, IsPublic = true, Name = "Cunning Fox Gamehall - Chess", MaxOccupancy = 25, Model = new RoomModel() { ModelName = "hallC" } });
            modelBuilder.Entity<Room>().HasData(new Room() { Id = 32, IsPublic = true, Name = "Cunning Fox Gamehall - Battleships", MaxOccupancy = 25, Model = new RoomModel() { ModelName = "hallB" } });
            modelBuilder.Entity<Room>().HasData(new Room() { Id = 33, IsPublic = true, Name = "Cunning Fox Gamehall - Tic Tac Toe", MaxOccupancy = 25, Model = new RoomModel() { ModelName = "hallA" } });
            modelBuilder.Entity<Room>().HasData(new Room() { Id = 34, IsPublic = true, Name = "Cunning Fox Gamehall - Poker", MaxOccupancy = 40, Model = new RoomModel() { ModelName = "hallD" } });
            modelBuilder.Entity<Room>().HasData(new Room() { Id = 35, IsPublic = true, Name = "Club Slinky Helsinki", MaxOccupancy = 40, Model = new RoomModel() { ModelName = "malja_bar_a" } });
            modelBuilder.Entity<Room>().HasData(new Room() { Id = 36, IsPublic = true, Name = "Club Slinky Helsinki - Part B", MaxOccupancy = 40, Model = new RoomModel() { ModelName = "malja_bar_b" } });
            */
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            switch (Config.Instance.DatabaseSource)
            {
                case DatabaseSource.InMemory:
                    optionsBuilder.UseInMemoryDatabase(Config.Instance.DatabasePath);
                    break;

                case DatabaseSource.Sqlite:
                    optionsBuilder.UseSqlite($"Filename=./{Config.Instance.DatabasePath}");
                    break;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
