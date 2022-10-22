using System.Text;

namespace Snouthill.Networking;

public class PacketWriter
{
    private const byte EndOfPacketMarker = 1;
    private const byte EndOfStringMarker = 2;

    private readonly MemoryStream _memoryStream = new();

    public void WriteOpcode(short opcode)
    {
        _memoryStream.Write(Base64Encoding.Encode(opcode, 2));
    }

    public void WriteByte(byte value)
    {
        _memoryStream.WriteByte(value);
    }

    public void WriteInt(int value)
    {
        _memoryStream.Write(Vl64Encoding.Encode(value));
    }

    public void WriteBool(bool value)
    {
        WriteInt(value ? 1 : 0);
    }

    public void WriteRawString(string value)
    {
        _memoryStream.Write(Encoding.ASCII.GetBytes(value));
    }

    public void WriteString(string value)
    {
        WriteRawString(value);
        WriteByte(EndOfStringMarker);
    }

    public void WriteEndOfPacket()
    {
        WriteByte(EndOfPacketMarker);
    }

    public void WritePair(string key, string value)
    {
        WriteRawString(key);
        WriteRawString(":");
        WriteRawString(value);
        WriteByte(13);
    }

    public byte[] ToArray()
    {
        return _memoryStream.ToArray();
    }
}