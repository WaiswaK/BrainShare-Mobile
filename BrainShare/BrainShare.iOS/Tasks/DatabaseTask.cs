using SQLite.Net;
using System;

[assembly: Xamarin.Forms.Dependency(typeof(BrainShare.iOS.Database.DBConnection))]

namespace BrainShare.iOS.Database
{
    class DBConnection : Interfaces.IDatabase
    {
        static string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
        static string libraryPath = System.IO.Path.Combine(documentsPath, "..", "Library"); // Library folder
        string dbPath = System.IO.Path.Combine(libraryPath, Core.Constant.dbName);

        public DBConnection()
        {
        }
        public SQLiteConnection GetConnection()
        {
            var conn = new SQLiteConnection(new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS(), dbPath, true, null, null, null, null); 
            return conn;
        }
        public async System.Threading.Tasks.Task InitializeDatabase()
        {
            if (await LocalDatabaseNotPresent(Core.Constant.dbName))
            {
                using (var db = GetConnection())
                {
                    db.CreateTable<BrainShare.Database.Subject>();
                    db.CreateTable<BrainShare.Database.Topic>();
                    db.CreateTable<BrainShare.Database.Assignment>();
                    db.CreateTable<BrainShare.Database.Attachment>();
                    db.CreateTable<BrainShare.Database.Video>();
                    db.CreateTable<BrainShare.Database.User>();
                    db.CreateTable<BrainShare.Database.School>();
                    db.CreateTable<BrainShare.Database.Book>();
                    db.CreateTable<BrainShare.Database.log>();

                    db.CreateTable<Database.Pastpaper>();
                    db.CreateTable<Database.BSOUser>();
                };
            }
            else
            {
            }
        }
        public async System.Threading.Tasks.Task<bool> LocalDatabaseNotPresent(string fileName)
        {
            if (!System.IO.File.Exists(dbPath))
                return true;
            else
                return false;
        }      
    }
}
