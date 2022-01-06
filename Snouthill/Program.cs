using Serilog;
using Serilog.Events;
using Serilog.Exceptions;
using Serilog.Exceptions.Core;
using Serilog.Exceptions.EntityFrameworkCore.Destructurers;
using Snouthill;
using Snouthill.Db;
using Snouthill.Game;
using Snouthill.Net;

var host = Host.CreateDefaultBuilder(args)
    .UseConsoleLifetime()
    .ConfigureServices(services =>
    {
        services.AddHostedService<Worker>();

        services.AddSingleton<IRoomManager, RoomManager>();
        services.AddSingleton<IRoomLayoutManager, RoomLayoutManager>();

        services.AddSingleton<IPlayerManager, PlayerManager>();

        services.AddSingleton<ICatalogManager, CatalogManager>();

        services.AddSingleton<IServer<GameClient>, GameServer>();

        services.AddTransient<IRequestDispatcher, RequestDispatcher>();
    })
    .ConfigureAppConfiguration(config =>
    {
        Log.Logger = new LoggerConfiguration()
            .Enrich.WithExceptionDetails(new DestructuringOptionsBuilder()
                .WithDefaultDestructurers()
                .WithDestructurers(new[] {new DbUpdateExceptionDestructurer()}))
            .WriteTo.Console(outputTemplate:
                "[{Timestamp:HH:mm:ss} {Level:u3}] {Message}{NewLine}{Exception}")
            .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)
            .MinimumLevel.Verbose()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
            .CreateLogger();
    })
    .UseSerilog()
    .Build();

await using (var db = new DatabaseContext())
{
    await db.Database.EnsureCreatedAsync();
}

await host.RunAsync();