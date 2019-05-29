using Serilog;
using Snouthill.Db;
using Snouthill.Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snouthill.Game
{
    class Player
    {

    }

    class FurniDefinition
    {

    }

    class Furni
    {

    }

    struct RoomTile
    {
        public int Height { get; }
        public bool Inaccessible => Height == -1;

        public IEnumerable<Furni>
    }

    class RoomLayout
    {
        public int Length { get; }
        public int Width { get; }

        public RoomTile this[int x, int y] => _tiles[x, y];
        private RoomTile[,] _tiles;

        public RoomLayout(int length, int width, string heightMap)
        {
            _tiles = new RoomTile[length, width];
        }
    }

    class Room
    {
        public IEnumerable<Player> Players => _players;
        private List<Player> _players;

        public Room()
        {
            _players = new List<Player>();
        }

        public void Add(Player player)
        {
            _players.Add(player);
        }

        public void Remove(Player player)
        {
            _players.Remove(player);
        }
    }

    /*
    abstract class Occupant
    {

    }

    class UserOccupant : Occupant
    {

    }

    class BotOccupant : Occupant
    {
        public BotModel Model { get; }

        public BotOccupant(BotModel model)
        {
            Model = model;
        }
    }

    class Furni
    {
        public FurniModel Definition { get; }

        public PlacedFurniModel Model { get; }

        public Furni(PlacedFurniModel model)
        {
            Model = model;

            if (model.Furni == null)
            {
                using (var db = new DatabaseContext())
                {
                    db.Entry(model).Reference(f => f.Furni).Load();
                }
            }
            Definition = model.Furni;
        }
    }
    

    class RoomLayout
    {
        public FloorPlanModel FloorPlan { get; }

        public int[,] HeightMap { get; }

        public IEnumerable<Furni> Furnis => _furnis;
        private List<Furni> _furnis;

        public int Length { get; }
        public int Width { get; }

        public RoomLayout(RoomModel model)
        {
            if (model.FloorPlan == null) {
                using (var db = new DatabaseContext())
                {
                    db.Entry(model).Reference(r => r.FloorPlan).Load();
                }
            }

            FloorPlan = model.FloorPlan;

            Length = FloorPlan.Size.Length;
            Width = FloorPlan.Size.Width;

            HeightMap = new int[Length, Width];
            LoadHeightMap(FloorPlan.HeightMap);
        }

        private void LoadHeightMap(string heightMap)
        {
            var rows = heightMap.Split(' ');
            for (var y = 0; y < rows.Length; y++)
            {
                var row = rows[y];
                for (var x = 0; x < row.Length; x++)
                {
                    var cell = row[x];
                    if (!char.IsDigit(cell) && cell != 'x')
                    {
                        Log.Error("Height map for {floorPlanName} contains an invalid character", FloorPlan.Name);
                        return;
                    }

                    HeightMap[x, y] = cell;
                }
            }
        }

        private bool ContainsTile(int x, int y)
        {
            return x >= 0 && y >= 0 && x < Length && y < Width;
        }

        public bool IsTileValid(int x, int y)
        {
            if (!ContainsTile(x, y))
            {
                return false;
            }

            if (Tiles[x, y].Inaccessible)
            {
                return false;
            }

            //TODO check highest item

            return true;
        }

        public void AddFurni(Furni furni)
        {
            _furnis.Add(furni);
            Layout.Tiles[furni.Model.Position.X, furni.Model.Position.Y].Furnis.Add(furni);
        }
    }

    class Room
    {
        public RoomModel Info { get; }

        public IEnumerable<Occupant> Occupants => _occupants;
        private List<Occupant> _occupants;

        public RoomLayout Layout { get; }

        public IEnumerable<Furni> Furnis => _furnis;
        private List<Furni> _furnis;

        public Room(RoomModel model)
        {
            Info = model;

            _occupants = new List<Occupant>();
            using (var db = new DatabaseContext()) {
                foreach (var bot in db.Bots.Where(b => b.RoomId == Info.Id))
                {
                    _occupants.Add(new BotOccupant(bot));
                }
            }

            Layout = new RoomLayout(Info);

            _furnis = new List<Furni>();
            foreach(var furniModel in model.Furnis)
            {
                var furni = new Furni(furniModel);
                _furnis.Add(furni);
                
            }
        }
    }
    */
}
