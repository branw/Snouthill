namespace Snouthill.Util;

internal static class Base64Encoding
{
    public static byte[] Encode(int i, int numBytes)
    {
        var result = new byte[numBytes];
        for (var j = 1; j <= numBytes; j++)
        {
            var k = (numBytes - j) * 6;
            result[j - 1] = (byte) (0x40 + ((i >> k) & 0x3f));
        }

        return result;
    }

    public static int Decode(byte[] buffer)
    {
        var i = 0;
        var j = 0;
        for (var k = buffer.Length - 1; k >= 0; k--)
        {
            var x = buffer[k] - 0x40;
            if (j > 0)
                x *= (int) Math.Pow(64.0, j);

            i += x;
            j++;
        }

        return i;
    }
}