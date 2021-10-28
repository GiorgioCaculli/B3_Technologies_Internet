using System.Data.SqlClient;

namespace Infrastructure.SQLServer
{
    public class Database
    {
        private static string ConnectionString = "Server=127.0.0.1,1433;Database=gamer_history;User Id=SA;Password=P455W0rD;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}