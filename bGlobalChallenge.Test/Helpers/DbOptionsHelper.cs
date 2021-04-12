using bGlobalChallgenge.Persistence.Context;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace bGlobalChallenge.Test.Helpers
{
    public class DbOptionsHelper
    {
        public static DbContextOptions<DataContext> InMemoryOptions()
        {
            var connection = new SqliteConnection("DataSource=:memory:");
            connection.Open();

            return new DbContextOptionsBuilder<DataContext>()
                    .UseSqlite(connection)
                    .Options;
        }
    }
}
