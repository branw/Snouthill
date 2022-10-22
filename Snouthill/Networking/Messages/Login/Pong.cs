namespace Snouthill.Networking.Messages.Login;

// v9  hh_entry/Login Handler
//     send("PONG")
[Opcode(196)] // "PONG"
public record Pong : IInboundMessage<Pong>
{
    public static Pong Deserialize(PacketReader reader) => new();
}