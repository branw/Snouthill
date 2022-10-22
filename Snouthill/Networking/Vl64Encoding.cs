namespace Snouthill.Networking;

public class Vl64Encoding
{
    private const int MaximumBytes = 6;

    public static byte[] Encode(int i)
    {
        var wf = new byte[MaximumBytes];

        var pos = 0;
        var numBytes = 1;
        var startPos = pos;
        var negativeMask = i >= 0 ? 0 : 4;

        i = Math.Abs(i);

        wf[pos++] = (byte) (64 + (i & 3));

        for (i >>= 2; i != 0; i >>= MaximumBytes)
        {
            numBytes++;
            wf[pos++] = (byte) (64 + (i & 0x3f));
        }

        wf[startPos] = (byte) (wf[startPos] | (numBytes << 3) | negativeMask);

        return wf[..numBytes];
    }

    public static int Decode(ReadOnlySpan<byte> bzData)
    {
        var pos = 0;
        var v = 0;

        var negative = (bzData[pos] & 4) == 4;
        var totalBytes = (bzData[pos] >> 3) & 7;

        v = bzData[pos] & 3;

        pos++;

        var shiftAmount = 2;

        for (var b = 1; b < totalBytes; b++)
        {
            v |= (bzData[pos] & 0x3f) << shiftAmount;
            shiftAmount = 2 + 6 * b;
            pos++;
        }

        if (negative) v *= -1;

        return v;
    }
}