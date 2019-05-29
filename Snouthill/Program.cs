using Microsoft.Extensions.Hosting;
using System.Threading.Tasks;
using Serilog;
using Microsoft.Extensions.DependencyInjection;
using Serilog.Events;
using Snouthill.Util;

namespace Snouthill
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await new HostBuilder()
                .UseConsoleLifetime()
                .ConfigureServices((hostContext, services) =>
                {
                    // Hide hosting messages shown on the console
                    services.Configure<ConsoleLifetimeOptions>(options => options.SuppressStatusMessages = true);

                    services.AddHostedService<ServerManager>();
                })
                .ConfigureAppConfiguration(config =>
                {
                    Log.Logger = new LoggerConfiguration()
                        .Enrich.WithCaller()
                        .WriteTo.Console(outputTemplate:
                            "[{Timestamp:HH:mm:ss} {Level:u3}] {Message} (at {Caller}){NewLine}{Exception}")
                        .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day)
                        .MinimumLevel.Verbose()
                        .MinimumLevel.Override("Microsoft", LogEventLevel.Warning)
                        .CreateLogger();
                })
                .UseSerilog()
                .Build()
                .RunAsync();
        }
    }
}
