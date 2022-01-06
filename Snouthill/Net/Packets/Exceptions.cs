namespace Snouthill.Net.Packets;

public abstract class ClientException : Exception
{
}

public class PlayerNotAuthenticatedException : ClientException
{
}

public class PlayerNotInRoomException : ClientException
{
}

public abstract class ServerException : Exception
{
}