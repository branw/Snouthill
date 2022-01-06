using Snouthill.Game;

namespace Snouthill.Net.Packets;

public static class RequestValidator
{
    public static void VerifyPlayerAuthenticated(Player player)
    {
        if (player.Name == null) throw new PlayerNotAuthenticatedException();
    }

    public static void VerifyPlayerInRoom(Player player)
    {
        if (player.Room == null) throw new PlayerNotInRoomException();
    }
}