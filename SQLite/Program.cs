using System.Data.Entity;
using SQliteEF6;

namespace SQLite
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new SqliteContext("test.db"))
            {
                db.Tests.Load();
            }
        }
    }
}
