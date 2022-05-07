using FirstApp.Utils;
using SQLite;
using System;
using System.IO;

namespace FirstApp.Database
{
    public class Connection
    {
        private const string DatabaseFilename = "DB.db3";
        private const SQLite.SQLiteOpenFlags Flags =
            // open the database in read/write mode
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLite.SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLite.SQLiteOpenFlags.SharedCache;
        private static string BasePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
        private static string DatabasePath = Path.Combine(BasePath, DatabaseFilename);


        public static readonly AsyncLazy<SQLiteAsyncConnection> Instance = new AsyncLazy<SQLiteAsyncConnection>(async () =>
        {
            SQLiteAsyncConnection Database = new SQLiteAsyncConnection(DatabasePath, Flags);
            CreateTableResult createTableResult = await Database.CreateTableAsync<Settings>();
            return Database;
        });
    }
}
