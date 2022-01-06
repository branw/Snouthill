using Snouthill.Db.Models;

namespace Snouthill.Game;

public class RoomLayout
{
    public RoomLayout(RoomLayoutModel layoutModel)
    {
        Id = layoutModel.Id;
        Name = layoutModel.Name;
        HeightMap = layoutModel.HeightMap;
    }

    public string Id { get; }

    public string Name { get; }

    public string HeightMap { get; }
}