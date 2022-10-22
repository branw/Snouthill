namespace Snouthill.Networking.Messages.Room;

[Opcode(80)] // v7-v29 "CARRYDRINK", v30+ "CARRYOBJECT"
public record CarryDrink : IInboundMessage<CarryDrink>
{
    public static CarryDrink Deserialize(PacketReader reader) => new();
}