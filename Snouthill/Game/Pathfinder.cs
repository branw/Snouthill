namespace Snouthill.Game;

public static class Pathfinder
{
    public static bool IsValidTile(Room room, AEntity entity, (int X, int Y) position)
    {
        
        
        return false;
    }
    
    
    
    public static LinkedList<(int X, int Y)> MakePath(AEntity entity, int x, int y)
    {
        LinkedList<(int X, int Y)> positions = new();

        positions.AddFirst((x, y));
        
        return positions;
    }
}