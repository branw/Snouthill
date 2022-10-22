namespace Snouthill.Game;

public record Position(
    int X,
    int Y,
    double? Z = null,
    int? BodyRotation = null,
    int? HeadRotation = null)
{
    
}