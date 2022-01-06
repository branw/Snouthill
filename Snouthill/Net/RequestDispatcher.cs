using System.Linq.Expressions;
using Serilog;
using Snouthill.Game;
using Snouthill.Net.Packets;

namespace Snouthill.Net;

public class RequestDispatcher : IRequestDispatcher
{
    private readonly Dictionary<short, Func<PacketReader, IRequest>> _deserializers = new();
    private readonly Dictionary<short, Action<IRequest, Player>> _handlers = new();
    private readonly IServiceScopeFactory _serviceScopeFactory;

    private int _initialized;

    public RequestDispatcher(IServiceScopeFactory serviceScopeFactory)
    {
        _serviceScopeFactory = serviceScopeFactory;
    }

    public void EnsureLoaded()
    {
        if (Interlocked.CompareExchange(ref _initialized, 1, 0) == 1) return;

        LoadRequestTypes();
    }

    public IRequest? Deserialize(short opcode, PacketReader reader)
    {
        EnsureLoaded();

        if (!_deserializers.TryGetValue(opcode, out var deserializer)) return null;

        return deserializer(reader);
    }

    public bool Handle(short opcode, IRequest request, Player player)
    {
        EnsureLoaded();

        if (!_handlers.TryGetValue(opcode, out var handler)) return false;

        handler(request, player);
        return true;
    }

    private void LoadRequestTypes()
    {
        var requestTypes = new Dictionary<short, Type>();
        var deserializerTypes = new Dictionary<Type, Type>();
        var handlerTypes = new Dictionary<Type, Type>();

        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        foreach (var type in assembly.GetTypes())
            // Register request types that have an opcode attribute
            if (type != typeof(IRequest) && typeof(IRequest).IsAssignableFrom(type))
            {
                var attribs = type.GetCustomAttributes(typeof(RequestOpcodeAttribute), false);
                if (attribs.FirstOrDefault() is not RequestOpcodeAttribute attrib)
                {
                    Log.Warning("Type {typeName} is a request but is missing an opcode attribute",
                        type.Name);
                    continue;
                }

                requestTypes[attrib.Opcode] = type;
            }
            // Register deserializer types
            else if (type.GetInterfaces().Any(t =>
                         t.IsGenericType && t.GetGenericTypeDefinition() == typeof(IRequestDeserializer<>)))

            {
                var requestType = type.GetInterfaces()
                    .FirstOrDefault(t => t.GetGenericTypeDefinition() == typeof(IRequestDeserializer<>))
                    !.GetGenericArguments()[0];

                deserializerTypes[requestType] = type;
            }
            // Register handler types
            else if (type.GetInterfaces().Any(t =>
                         t.IsGenericType && t.GetGenericTypeDefinition() == typeof(IRequestHandler<>)))

            {
                var requestType = type.GetInterfaces()
                    .FirstOrDefault(t => t.GetGenericTypeDefinition() == typeof(IRequestHandler<>))
                    !.GetGenericArguments()[0];

                handlerTypes[requestType] = type;
            }

        var unknownDeserializers = deserializerTypes.Keys.Except(requestTypes.Values).ToList();
        var unknownHandlers = handlerTypes.Keys.Except(requestTypes.Values).ToList();
        if (unknownDeserializers.Any() || unknownHandlers.Any())
            Log.Warning("These deserializers and/or handlers do not have a valid request (possibly" +
                        "because the request type is missing an opcode attribute). " +
                        "Deserializers: {typeName}. Handlers: {typeName}",
                string.Join(", ", unknownDeserializers.Select(t => t.Name)),
                string.Join(", ", unknownHandlers.Select(t => t.Name)));

        foreach (var (opcode, requestType) in requestTypes)
            if (BuildDeserializers(opcode, requestType, deserializerTypes))
                BuildHandlers(opcode, requestType, handlerTypes);
    }

    private bool BuildDeserializers(short opcode, Type requestType, IReadOnlyDictionary<Type, Type> deserializerTypes)
    {
        var constructor = requestType.GetConstructors().FirstOrDefault();
        if (constructor == null)
        {
            Log.Warning("Unable to find constructor for request type {typeName}",
                requestType.Name);
            return false;
        }

        // Check that we have a valid deserializer method if the request type has a non-default constructor, i.e.
        // if it has any data.
        var hasData = constructor.GetParameters().Length > 0;
        if (!deserializerTypes.TryGetValue(requestType, out var deserializerType) && hasData)
        {
            Log.Warning("Unable to find deserializer for request type {typeName}; {params}",
                requestType.Name,
                constructor.GetParameters());
            return false;
        }

        // Build an expression for deserializing the packet (either call new directly, or use the deserializer)

        var readerParameterExpression = Expression.Parameter(typeof(PacketReader));

        Expression deserializerExpression;
        if (hasData)
            deserializerExpression = Expression.Call(
                Expression.New(deserializerType), deserializerType.GetMethod("Deserialize")!,
                readerParameterExpression);
        else
            deserializerExpression = Expression.New(requestType);

        _deserializers[opcode] = Expression.Lambda<Func<PacketReader, IRequest>>(
            deserializerExpression,
            readerParameterExpression).Compile();
        return true;
    }

    private bool BuildHandlers(short opcode, Type requestType, IReadOnlyDictionary<Type, Type> handlerTypes)
    {
        if (!handlerTypes.TryGetValue(requestType, out var handlerType))
        {
            Log.Warning("Unable to find handler for request type {typeName}",
                requestType.Name);
            return false;
        }

        // Build an expression for handling the packet (create and inject the handler, then run)

        var handlerConstructor = handlerType.GetConstructors().FirstOrDefault();
        if (handlerConstructor == null)
        {
            Log.Warning("Unable to find constructor for handler type {typeName}",
                handlerType.Name);
            return false;
        }

        var handlerRequestParameterExpression = Expression.Parameter(typeof(IRequest));
        var handlerPlayerParameterExpression = Expression.Parameter(typeof(Player));

        NewExpression handlerTypeInitExpr;
        var handlerConstructorParameters = handlerConstructor.GetParameters();
        if (handlerConstructorParameters.Length > 0)
        {
            List<Expression> args = new();

            // Manually inject singleton dependencies
            using var scope = _serviceScopeFactory.CreateScope();
            foreach (var parameter in handlerConstructorParameters)
            {
                var service = scope.ServiceProvider.GetService(parameter.ParameterType);
                if (service == null)
                {
                    Log.Warning("Unable to find service {typeName} for handler type {typeName}",
                        parameter.ParameterType.Name, requestType.Name);
                    continue;
                }

                args.Add(Expression.Constant(service));
            }

            handlerTypeInitExpr = Expression.New(handlerConstructor, args);
        }
        else
        {
            handlerTypeInitExpr = Expression.New(handlerType);
        }

        _handlers[opcode] = Expression.Lambda<Action<IRequest, Player>>(
            Expression.Call(handlerTypeInitExpr, handlerType.GetMethod("Handle")!,
                Expression.TypeAs(handlerRequestParameterExpression, requestType),
                handlerPlayerParameterExpression),
            handlerRequestParameterExpression,
            handlerPlayerParameterExpression).Compile();

        return true;
    }
}