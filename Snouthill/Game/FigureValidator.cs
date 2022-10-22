namespace Snouthill.Game;

public static class FigureValidator
{
    public static bool IsValid(string figure)
    {
        if (figure.Length != (3 + 2) * 5)
            return false;

        List<(int Sprite, int Color)> components = new();
        for (var offset = 0; offset < (3 + 2) * 5; offset += 5)
        {
            components.Add((
                int.Parse(figure[offset..(offset+3)]),
                int.Parse(figure[(offset+3)..(offset+5)])));
        }

        // hr hd ch lg sh

        return true;
    }
}