using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Newtonsoft.Json;
using Snouthill.Database.Models;
using Snouthill.Database.StaticData;

namespace Snouthill.Database;

public class DatabaseContext : DbContext
{
    public DbSet<PlayerModel> Players => Set<PlayerModel>();

    public DbSet<BadgeModel> Badges => Set<BadgeModel>();

    public DbSet<ExternalTextModel> ExternalText => Set<ExternalTextModel>();

    // public DbSet<FriendModel> Friends => Set<FriendModel>();
    public DbSet<FriendRequestModel> FriendRequests => Set<FriendRequestModel>();

    public DbSet<MessageModel> Messages => Set<MessageModel>();

    public DbSet<RoomModel> Rooms => Set<RoomModel>();
    public DbSet<RoomLayoutModel> RoomLayouts => Set<RoomLayoutModel>();
    public DbSet<RoomCategoryModel> RoomCategories => Set<RoomCategoryModel>();

    public DbSet<PublicItemModel> PublicItems => Set<PublicItemModel>();

    public DbSet<CatalogPageModel> CatalogPages => Set<CatalogPageModel>();
    public DbSet<CatalogItemModel> CatalogItems => Set<CatalogItemModel>();
    public DbSet<CatalogPackageModel> CatalogPackages => Set<CatalogPackageModel>();

    private static List<TEntity> LoadStaticData<TEntity>(string fileName)
    {
        var currentDirectory = Directory.GetCurrentDirectory();
        var fullPath = Path.Combine(currentDirectory, "StaticData", fileName);

        using var reader = new StreamReader(fullPath);
        var json = reader.ReadToEnd();
        
        return JsonConvert.DeserializeObject<List<TEntity>>(json) ?? 
               throw new InvalidDataException($"Could not deserialize static data for {fileName}");
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BadgeModel>(eb =>
        {
            eb.HasKey(bm => new {bm.Name, bm.OwnerPlayerId});
        });

        modelBuilder.Entity<ExternalTextModel>(eb =>
        {
            eb.HasData(ExternalTextModels.Models);
        });

        modelBuilder.Entity<CatalogPageModel>(eb =>
        {
            eb.HasData(CatalogPageModels.Models);
        });

        var commaListConverter = new ValueConverter<IEnumerable<int>, string>(
            v => string.Join(",", v),
            v => v.Split(new[] {','}).Select(int.Parse));
        modelBuilder.Entity<CatalogItemModel>(eb =>
        {
            eb.HasData(CatalogItemModels.Models);

            eb.Property(p => p.PageIds)
                .HasConversion(commaListConverter);
        });

        modelBuilder.Entity<CatalogPackageModel>(eb =>
        {
            eb.HasData(CatalogPackageModels.Models);
        });

        // modelBuilder.Entity<FriendModel>(eb =>
        // {
        //     eb.HasNoKey();
        //
        //     // eb.HasOne(f => f.Sender)
        //     //     .WithMany(p => p.Friends)
        //     //     .HasForeignKey(f => f.SenderPlayerId);
        //     //
        //     // eb.HasOne(f => f.Receiver)
        //     //     .WithMany(p => p.Friends)
        //     //     .HasForeignKey(f => f.ReceiverPlayerId);
        // });
        
        modelBuilder.Entity<FriendRequestModel>(eb =>
        {
            eb.HasNoKey();
        });

        modelBuilder.Entity<PlayerModel>(eb =>
        {
            eb.HasIndex(p => p.Name)
                .IsUnique();
            
            eb.HasData(new PlayerModel
            {
                PlayerId = 1,
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
        
        modelBuilder.Entity<RoomModel>(eb =>
        {
            eb.HasData(RoomModels.Models);
        });

        modelBuilder.Entity<RoomLayoutModel>(eb =>
        {
            eb.HasData(RoomLayoutModels.Models);
        });

        modelBuilder.Entity<RoomCategoryModel>(eb =>
        {
            eb.HasData(RoomCategoryModels.Models);
        });
        
        modelBuilder.Entity<PublicItemModel>(eb =>
        {
            eb.HasData(PublicItemModels.Models);
        });
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