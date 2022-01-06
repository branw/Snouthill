using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Snouthill.Db.Models;
using Snouthill.Db.StaticData;

namespace Snouthill.Db;

public class DatabaseContext : DbContext
{
    public DbSet<PlayerModel> Players { get; set; }

    public DbSet<BadgeModel> Badges { get; set; }

    public DbSet<FriendModel> Friends { get; set; }
    public DbSet<FriendRequestModel> FriendRequests { get; set; }

    public DbSet<MessageModel> Messages { get; set; }

    public DbSet<RoomModel> Rooms { get; set; }
    public DbSet<RoomLayoutModel> RoomLayouts { get; set; }
    public DbSet<RoomCategoryModel> RoomCategories { get; set; }

    public DbSet<CatalogPageModel> CatalogPages { get; set; }
    public DbSet<CatalogItemModel> CatalogItems { get; set; }
    public DbSet<CatalogPackageModel> CatalogPackages { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BadgeModel>(eb => { eb.HasKey(bm => new {bm.Name, bm.OwnerName}); });

        modelBuilder.Entity<CatalogPageModel>(eb => { eb.HasData(CatalogPageModels.Models); });

        var commaListConverter = new ValueConverter<IEnumerable<int>, string>(
            v => string.Join(",", v),
            v => v.Split(new[] {','}).Select(int.Parse));
        modelBuilder.Entity<CatalogItemModel>(eb =>
        {
            eb.HasData(CatalogItemModels.Models);

            eb.Property(p => p.PageIds)
                .HasConversion(commaListConverter);
        });

        modelBuilder.Entity<CatalogPackageModel>(eb => { eb.HasData(CatalogPackageModels.Models); });

        modelBuilder.Entity<FriendModel>(eb => { eb.HasNoKey(); });

        modelBuilder.Entity<FriendRequestModel>(eb => { eb.HasNoKey(); });

        modelBuilder.Entity<PlayerModel>(eb =>
        {
            eb.HasData(new PlayerModel
            {
                Name = "foo",
                Password = "bar",
                Email = "foo@bar.com",
                Birthday = "01.01.1990",
                Figure = "1000118001265012850121001",
                Sex = "M",
                Motto = "My Motto",
                Credits = 50,
                Tickets = 5
            });
        });

        modelBuilder.Entity<RoomCategoryModel>(eb => { eb.HasData(RoomCategoryModels.Models); });

        modelBuilder.Entity<RoomModel>(eb =>
        {
            eb.HasData(
                new RoomModel
                {
                    Id = 1, OwnerName = "", Category = 3,
                    Name = "Welcome Lounge", Description = "welcome_lounge",
                    LayoutName = "newbie_lobby", FileNames = "hh_room_nlobby",
                    ShowOwnerName = false, MaxVisitors = 40
                },
                new RoomModel
                {
                    Id = 2, OwnerName = "", Category = 3,
                    Name = "Theatredrome", Description = "theatredrome",
                    LayoutName = "theater", FileNames = "hh_room_theater",
                    ShowOwnerName = false, MaxVisitors = 100
                });
        });

        modelBuilder.Entity<RoomLayoutModel>(eb => { eb.HasData(RoomLayoutModels.Models); });
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();

        switch (Config.DatabaseSource)
        {
            case DatabaseSource.InMemory:
                optionsBuilder.UseInMemoryDatabase(Config.DatabasePath);
                break;

            case DatabaseSource.Sqlite:
                optionsBuilder.UseSqlite($"Filename=./{Config.DatabasePath}");
                break;

            default:
                throw new NotImplementedException();
        }
    }
}