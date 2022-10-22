using Snouthill.Database.Models;

namespace Snouthill.Game;

public class RoomLayout
{
    public RoomLayout(RoomLayoutModel layoutModel)
    {
        Id = layoutModel.Id;
        Name = layoutModel.Name;
        HeightMap = layoutModel.HeightMap;
        DoorPosition = (layoutModel.DoorX, layoutModel.DoorY, layoutModel.DoorZ);
        DoorDirection = layoutModel.DoorDirection;
    }

    public string Id { get; }

    public string Name { get; }

    public string HeightMap { get; }
    
    public (int X, int Y, double Z) DoorPosition { get; }
    public int DoorDirection { get; }
}