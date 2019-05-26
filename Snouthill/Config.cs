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

    class Config
    {
        /// <summary>
        /// TCP port to host login and messenger server; up to the next 100
        /// ports may also be reserved for public room servers
        /// </summary>
        public ushort MainPort { get; set; } = 37080;
        /// <summary>
        /// TCP port to host private room server
        /// </summary>
        public ushort PrivateRoomPort { get; set; } = 37079;
        public string DatabasePath { get; set; } = "Snouthill.db";
        public DatabaseSource DatabaseSource { get; set; } = DatabaseSource.Sqlite;
        /// <summary>
        /// Automatically promote the first registered user to the superuser role
        /// </summary>
        public bool FirstUserSuperuser { get; set; } = true;
        /// <summary>
        /// Minimum time delay, in milliseconds, between game updates
        /// </summary>
        public int Timestep { get; set; } = 1000;


        private static Config _instance;
        public static Config Instance => _instance ?? (_instance = new Config());
    }
}
