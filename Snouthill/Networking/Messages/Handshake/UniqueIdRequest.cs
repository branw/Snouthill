namespace Snouthill.Networking.Messages.Inbound;

[Opcode(6)] // "UNIQUEID"
public record UniqueIdRequest(
    string MachineId) : IInboundMessage<UniqueIdRequest>
{
    public static UniqueIdRequest Deserialize(PacketReader reader)
    {
        var machineId = reader.ReadString();

        return new UniqueIdRequest(machineId);
    }
}