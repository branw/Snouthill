using System.Linq.Expressions;
using Serilog;

namespace Snouthill.Networking.Messages;

public static class OpcodeManager
{
    private static IReadOnlyDictionary<short, Func<PacketReader, IHandleableMessage>>? _deserializers;
    private static IReadOnlyDictionary<Type, short>? _outboundOpcodes;

    public static void Initialize()
    {
        Dictionary<short, Func<PacketReader, IHandleableMessage>> deserializers = new();
        Dictionary<Type, short> outboundTypesToOpcodes = new();
        Dictionary<short, Type> outboundOpcodesToTypes = new();
        Dictionary<short, Type> inboundOpcodesToTypes = new();

        // Check all types for an Opcode attribute
        foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
        foreach (var type in assembly.GetTypes())
        {
            var attribs = (OpcodeAttribute[]) type.GetCustomAttributes(typeof(OpcodeAttribute), false);
            if (attribs.Length == 0) continue;

            var opcode = attribs[0].Opcode;
            if (type.GetInterfaces().Any(i => 
                    i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IInboundMessage<>)))
            {
                if (inboundOpcodesToTypes.TryGetValue(opcode, out var existingType))
                {
                    throw new InvalidOperationException($"Tried to register inbound opcode {opcode} to " +
                                                        $"{type}, but it is already registered to {existingType}");
                }

                inboundOpcodesToTypes.Add(opcode, type);
                
                var deserializeMethod = type.GetMethod("Deserialize")!;

                // Create a stub expression for calling the deserialize method
                var readerParameter = Expression.Parameter(typeof(PacketReader), "reader");
                var deserializerFunc = Expression.Lambda<Func<PacketReader, IHandleableMessage>>(
                    Expression.Call(null, deserializeMethod, readerParameter), readerParameter).Compile();

                deserializers.Add(opcode, deserializerFunc);
            }
            else if (type != typeof(IOutboundMessage) && typeof(IOutboundMessage).IsAssignableFrom(type))
            {
                if (outboundOpcodesToTypes.TryGetValue(opcode, out var existingType))
                {
                    throw new InvalidOperationException($"Tried to register outbound opcode {opcode} to " +
                                                        $"{type}, but it is already registered to {existingType}");
                }
                
                outboundTypesToOpcodes.Add(type, opcode);
                outboundOpcodesToTypes.Add(opcode, type);
            }
        }

        _deserializers = deserializers;
        _outboundOpcodes = outboundTypesToOpcodes;
    }

    public static IHandleableMessage? Deserialize(short opcode, PacketReader reader)
    {
        if (_deserializers == null)
            throw new InvalidOperationException("Message dispatcher is not initialized");

        if (!_deserializers.TryGetValue(opcode, out var deserializer))
            return null;

        return deserializer(reader);
    }

    public static short? GetOpcode(IOutboundMessage message) => GetOpcode(message.GetType());
    
    private static short? GetOpcode(Type type)
    {
        if (_outboundOpcodes?.TryGetValue(type, out var opcode) != true)
            return null;

        return opcode;
    }
}