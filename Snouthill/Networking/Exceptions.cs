namespace Snouthill.Networking;

public class ClientException : Exception
{
}

public class AbnormalInputException : ClientException
{
}

public class PlayerNotAuthenticatedException : ClientException
{
}

public class PlayerNotInRoomException : ClientException
{
}

public class ServerException : Exception
{
}