using System;
using System.Collections.Generic;
using System.Text;

namespace Snouthill
{
    public enum DatabaseSource
    {
        InMemory,
        Sqlite,
    }

    static class ServerConfig
    {
        /// <summary>
        /// TCP port to host login and messenger server; up to the next 100
        /// ports may also be reserved for public room servers
        /// </summary>
        public static ushort MainPort { get; set; } = 37080;
        /// <summary>
        /// TCP port to host private room server
        /// </summary>
        public static ushort PrivateRoomPort { get; set; } = 37079;

        public static string DatabasePath { get; set; } = "Snouthill.db";
        public static DatabaseSource DatabaseSource { get; set; } = DatabaseSource.Sqlite;
        
        /// <summary>
        /// Automatically promote the first registered user to the superuser role
        /// </summary>
        public static bool FirstUserSuperuser { get; set; } = true;
        
        /// <summary>
        /// Minimum time delay, in milliseconds, between game updates
        /// </summary>
        public static int Timestep { get; set; } = 1000;
    }
}
