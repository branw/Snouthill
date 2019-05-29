using Microsoft.EntityFrameworkCore;
using Snouthill.Db.Models;
using System;

namespace Snouthill.Db
{
    class DatabaseContext : DbContext
    {
        public DbSet<RoomModel> Rooms { get; set; }

        public DbSet<FloorPlanModel> FloorPlans { get; set; }

        public DbSet<UserModel> Users { get; set; }

        public DbSet<BotModel> Bots { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RoomModel>(builder =>
            {
                foreach(var publicRoom in DataLoader.PublicRooms)
                {
                    builder.HasData(publicRoom);
                }
            });

            modelBuilder.Entity<FloorPlanModel>(builder =>
            {
                foreach(var floorPlan in DataLoader.FloorPlans)
                {
                    builder.HasData(floorPlan);
                }
            });

            modelBuilder.Entity<UserModel>(builder =>
            {
                builder.HasAlternateKey(u => u.Username);
            });

            modelBuilder.Entity<BotModel>(builder =>
            {
                foreach(var bot in DataLoader.Bots)
                {
                    builder.HasData(bot);
                }
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            switch (ServerConfig.DatabaseSource)
            {
                case DatabaseSource.InMemory:
                    optionsBuilder.UseInMemoryDatabase(ServerConfig.DatabasePath);
                    break;

                case DatabaseSource.Sqlite:
                    optionsBuilder.UseSqlite($"Filename=./{ServerConfig.DatabasePath}");
                    break;

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
