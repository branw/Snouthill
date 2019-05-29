using Snouthill.Db.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Snouthill.Db
{
    /// <summary>
    /// Loads and caches all fixed data, including furni definitions and public room info.
    /// </summary>
    static class DataLoader
    {
        public static IEnumerable<BotModel> Bots { get; }

        public static IEnumerable<RoomModel> PublicRooms { get; }

        public static IEnumerable<FloorPlanModel> FloorPlans { get; }

        public static IEnumerable<FurniDefinitionModel> FurniDefinitions { get; }

        public static IDictionary<int, FurniDefinitionModel> FurniDefinitionsById { get; }

        static DataLoader()
        {
            #region Bots
            Bots = new List<BotModel>()
            {
                //TODO
            };
            #endregion

            #region FloorPlans
            FloorPlans = new List<FloorPlanModel>()
            {
                new FloorPlanModel { Name = "model_a", Door = (3, 5, 0, 2), Size = (12, 16), HasPool = false },
                new FloorPlanModel { Name = "model_b", Door = (0, 5, 0, 2), Size = (12, 16), HasPool = false },
                new FloorPlanModel { Name = "model_c", Door = (4, 7, 0, 2), Size = (12, 16), HasPool = false },
                new FloorPlanModel { Name = "model_d", Door = (4, 7, 0, 2), Size = (12, 16), HasPool = false },
                new FloorPlanModel { Name = "model_e", Door = (1, 5, 0, 2), Size = (12, 16), HasPool = false },
                new FloorPlanModel { Name = "model_f", Door = (2, 5, 0, 2), Size = (12, 16), HasPool = false },

                new FloorPlanModel { Name = "entryhall", FileName = "lobby", Door = (17, 18, 1, 0), Size = (20, 21), HasPool = false },
                new FloorPlanModel { Name = "lobby_a", FileName = "lobby", Door = (12, 27, 0, 0), Size = (25, 31), HasPool = false },
                new FloorPlanModel { Name = "floorlobby_a", FileName = "lobby", Door = (9, 21, 0, 0), Size = (27, 22), HasPool = false },
                new FloorPlanModel { Name = "floorlobby_b", FileName = "lobby", Door = (9, 21, 0, 0), Size = (27, 22), HasPool = false },
                new FloorPlanModel { Name = "floorlobby_c", FileName = "lobby", Door = (9, 21, 0, 0), Size = (27, 22), HasPool = false },

                new FloorPlanModel { Name = "pool_a", FileName = "lido", Door = (2, 25, 7, 2), Size = (43, 48), HasPool = true },
                new FloorPlanModel { Name = "pool_b", FileName = "lido", Door = (9, 21, 7, 2), Size = (43, 48), HasPool = true },

                new FloorPlanModel { Name = "bar_a", FileName = "club", Door = (5, 1, 7, 2), Size = (19, 34), HasPool = false },
                new FloorPlanModel { Name = "bar_b", FileName = "club", Door = (2, 12, 4, 2), Size = (18, 31), HasPool = false },

                new FloorPlanModel { Name = "hallC", FileName = "gamehall", Door = (1, 1, 1, 4), Size = (17, 18), HasPool = false },
                new FloorPlanModel { Name = "hallA", FileName = "gamehall", Door = (1, 1, 1, 4), Size = (17, 18), HasPool = false },
                new FloorPlanModel { Name = "hallB", FileName = "gamehall", Door = (1, 1, 1, 4), Size = (17, 18), HasPool = false },
                new FloorPlanModel { Name = "hallD", FileName = "gamehall", Door = (1, 1, 1, 4), Size = (17, 18), HasPool = false },

                new FloorPlanModel { Name = "malja_bar_b", FileName = "disco", Door = (5, 24, 3, 0), Size = (16, 26), HasPool = false },
                new FloorPlanModel { Name = "malja_bar_a", FileName = "disco", Door = (4, 24, 1, 0), Size = (16, 25), HasPool = false },

                new FloorPlanModel { Name = "pub_a", FileName = "pub", Door = (15, 25, 0, 2), Size = (25, 31), HasPool = false },
                new FloorPlanModel { Name = "theater", FileName = "theatredome", Door = (20, 27, 0, 2), Size = (23, 30), HasPool = false },
                new FloorPlanModel { Name = "cr_kitchen", FileName = "kitchen", Door = (7, 21, 0, 2), Size = (19, 23), HasPool = false },
                new FloorPlanModel { Name = "taivas_cafe", FileName = "cafe", Door = (14, 29, 0, 2), Size = (20, 32), HasPool = false },
                new FloorPlanModel { Name = "habburger", FileName = "habburger", Door = (22, 10, 0, 6), Size = (23, 15), HasPool = false },
            };
            // Load all height maps
            foreach (var floorPlan in FloorPlans)
            {
                floorPlan.HeightMap = string.Join(' ', File.ReadAllLines($"Data/HeightMaps/{floorPlan.Name}"));
            }
            #endregion


            #region Rooms
            PublicRooms = new List<RoomModel>()
            {
                new PublicRoomModel { Id = 12, Name = "Main Lobby", MaxOccupancy = 40, FloorPlanName = "lobby_a" },
                new PublicRoomModel { Id = 13, Name = "Habbo Lido", MaxOccupancy = 40, FloorPlanName = "pool_a" },
                new PublicRoomModel { Id = 14, Name = "The Dirty Duck Pub", MaxOccupancy = 40, FloorPlanName = "pub_a" },
                new PublicRoomModel { Id = 16, Name = "Hotel Kitchen", MaxOccupancy = 25, FloorPlanName = "cr_kitchen" },
                new PublicRoomModel { Id = 17, Name = "Cafe Ole", MaxOccupancy = 40, FloorPlanName = "taivas_cafe" },
                new PublicRoomModel { Id = 19, Name = "Habburger's", MaxOccupancy = 40, FloorPlanName = "habburger" },
                new PublicRoomModel { Id = 21, Name = "Habbo Lido II", MaxOccupancy = 30, FloorPlanName = "pool_b" },
                new PublicRoomModel { Id = 22, Name = "Club Massiva", MaxOccupancy = 40, FloorPlanName = "bar_a" },
                new PublicRoomModel { Id = 24, Name = "Theatredrome", MaxOccupancy = 25, FloorPlanName = "theater" },
                new PublicRoomModel { Id = 25, Name = "Basement Lobby", MaxOccupancy = 35, FloorPlanName = "floorlobby_a" },
                new PublicRoomModel { Id = 26, Name = "Median Lobby", MaxOccupancy = 40, FloorPlanName = "floorlobby_b" },
                new PublicRoomModel { Id = 27, Name = "Skylight Lobby", MaxOccupancy = 40, FloorPlanName = "floorlobby_c" },
                new PublicRoomModel { Id = 29, Name = "Club Massiva (downstairs)", MaxOccupancy = 40, FloorPlanName = "bar_b" },
                new PublicRoomModel { Id = 30, Name = "Cunning Fox Gamehall", MaxOccupancy = 40, FloorPlanName = "entryhall" },
                new PublicRoomModel { Id = 31, Name = "Cunning Fox Gamehall - Chess", MaxOccupancy = 25, FloorPlanName = "hallC" },
                new PublicRoomModel { Id = 32, Name = "Cunning Fox Gamehall - Battleships", MaxOccupancy = 25, FloorPlanName = "hallB" },
                new PublicRoomModel { Id = 33, Name = "Cunning Fox Gamehall - Tic Tac Toe", MaxOccupancy = 25, FloorPlanName = "hallA" },
                new PublicRoomModel { Id = 34, Name = "Cunning Fox Gamehall - Poker", MaxOccupancy = 40, FloorPlanName = "hallD" },
                new PublicRoomModel { Id = 35, Name = "Club Slinky Helsinki", MaxOccupancy = 40, FloorPlanName = "malja_bar_a" },
                new PublicRoomModel { Id = 36, Name = "Club Slinky Helsinki - Part B", MaxOccupancy = 40, FloorPlanName = "malja_bar_b" }
            };
            #endregion

            #region Furnis
            FurniDefinitions = new List<FurniDefinitionModel>()
            {
                //TODO
            };
            #endregion
        }
    }
}
