using System.Text;

namespace Snouthill.Networking;

public class PacketReader
{
    private readonly byte[] _buffer;
    private int _offset;

    public PacketReader(ReadOnlySpan<byte> buffer)
    {
        _buffer = buffer.ToArray();
        _offset = 0;
    }

    public int Remaining => _buffer.Length - _offset;

    private void RequireLength(int length)
    {
        if (_buffer.Length - _offset < length)
            throw new IndexOutOfRangeException();
    }

    public ReadOnlySpan<byte> ReadBytes(int length)
    {
        RequireLength(length);
        var value = _buffer[_offset..(_offset + length)];
        _offset += length;
        return value;
    }

    // public V7Opcode ReadV7Opcode()
    // {
    //     return new V7Opcode(ReadBase64Short());
    // }
    //
    // public V1Opcode ReadV1Opcode()
    // {
    //     return new V1Opcode(ReadString());
    // }

    public short ReadBase64Short()
    {
        return (short) Base64Encoding.Decode(ReadBytes(2));
    }

    public string ReadString()
    {
        var length = ReadBase64Short();
        return Encoding.ASCII.GetString(ReadBytes(length));
    }

    public string ReadRawString()
    {
        return Encoding.ASCII.GetString(ReadBytes(Remaining));
    }

    public int ReadInt()
    {
        RequireLength(1);
        var length = (_buffer[_offset] >> 3) & 7;
        return Vl64Encoding.Decode(ReadBytes(length));
    }

    public byte ReadByte()
    {
        RequireLength(1);
        var value = _buffer[_offset];
        _offset += 1;
        return value;
    }

    public bool ReadBool() => ReadByte() != 0;
}