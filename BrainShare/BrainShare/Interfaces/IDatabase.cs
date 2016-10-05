using SQLite.Net;
using System.Threading.Tasks;

namespace BrainShare.Interfaces
{
    public interface IDatabase
    {
        Task InitializeDatabase();
        SQLiteConnection GetConnection();
    }
}
