namespace Snouthill;

internal enum DatabaseSource
{
    InMemory,
    Sqlite
}

internal static class Config
{
    /// <summary>
    ///     TCP port to host login and messenger server; up to the next 100
    ///     ports may also be reserved for public room servers
    /// </summary>
    public static ushort GamePort { get; set; } = 12321;

    /// <summary>
    ///     TCP port to host private room server
    /// </summary>
    public static ushort MusPort { get; set; } = 12322;

    public static string DatabasePath { get; set; } = "Snouthill.db";
    public static DatabaseSource DatabaseSource { get; set; } = DatabaseSource.Sqlite;

    /// <summary>
    ///     Automatically promote the first registered user to the superuser role
    /// </summary>
    public static bool FirstUserSuperuser { get; set; } = true;

    /// <summary>
    ///     Minimum time delay, in milliseconds, between game updates
    /// </summary>
    public static int TimeStep { get; set; } = 1000;
}