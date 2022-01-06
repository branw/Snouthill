using System.Text;
using Snouthill.Util;

namespace Snouthill.Net.Packets;

public class PacketWriter
{
    private static readonly byte END_OF_PACKET_MARKER = 1;
    private static readonly byte END_OF_STRING_MARKER = 2;
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
        WriteByte(END_OF_STRING_MARKER);
    }

    public void WriteEndOfPacket()
    {
        WriteByte(END_OF_PACKET_MARKER);
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