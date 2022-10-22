namespace Snouthill.Game;

public record CallForHelp(
    int CryId,
    string CallerId,
    string Message,
    int? RoomId,
    long CallTime,
    string? ResponderId = null,
    long? ResponseTime = null);