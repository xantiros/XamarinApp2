using SQLite;

namespace XamarinApp2.DataAccess
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}