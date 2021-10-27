using System.Data.SqlClient;

namespace Infrastructure.SQLServer
{
    public class Database
    {
        /* Docker: Server=127.0.0.1,1433;Database=;User Id=SA;Password=P455W0rD; */
        private const string ConnectionString = "Server=127.0.0.1,1433;Database=todos;User Id=SA;Password=P455W0rD;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}