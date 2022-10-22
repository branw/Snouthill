namespace Snouthill.Networking.Messages.Room.Furni.Trax;

[Opcode(221)] // "GET_SOUND_DATA"
public record GetSoundData : IInboundMessage<GetSoundData>
{
    public static GetSoundData Deserialize(PacketReader message)
    {
        throw new NotImplementedException();
    }
}