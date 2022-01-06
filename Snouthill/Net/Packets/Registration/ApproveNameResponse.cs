namespace Snouthill.Net.Packets.Registration;

public record ApproveNameResponse(
    ApproveNameResponse.ReplyType Reply) : IResponse
{
    public enum ReplyType
    {
        Accepted = 0,
        TooLong = 1,
        TooShort = 2,
        Forbidden = 3,
        AlreadyRegistered = 4
    }

    public short Opcode => 36;

    public void Serialize(PacketWriter writer)
    {
        writer.WriteInt((int) Reply);
    }
}