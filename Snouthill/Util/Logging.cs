using System.Diagnostics;
using Serilog;
using Serilog.Configuration;
using Serilog.Core;
using Serilog.Events;

namespace Snouthill.Util;

internal class CallerEnricher : ILogEventEnricher
{
    public void Enrich(LogEvent logEvent, ILogEventPropertyFactory propertyFactory)
    {
        var skip = 3;
        while (true)
        {
            var stack = new StackFrame(skip);
            if (!stack.HasMethod())
            {
                logEvent.AddPropertyIfAbsent(new LogEventProperty("Caller", new ScalarValue("<unknown method>")));
                return;
            }

            var method = stack.GetMethod();
            if (method != null && method.DeclaringType != null && method.DeclaringType.Assembly != typeof(Log).Assembly)
            {
                var caller =
                    $"{method.DeclaringType.FullName}.{method.Name}({string.Join(", ", method.GetParameters().Select(pi => pi.ParameterType.FullName))})";
                logEvent.AddPropertyIfAbsent(new LogEventProperty("Caller", new ScalarValue(caller)));
            }

            skip++;
        }
    }
}

internal static class LoggerEnrichmentConfigurationExtensions
{
    public static LoggerConfiguration WithCaller(this LoggerEnrichmentConfiguration enrichmentConfiguration)
    {
        return enrichmentConfiguration.With<CallerEnricher>();
    }
}