using System.Data.SqlClient;

namespace Infrastructure.SqlServer
{
    public class Database
    {
        /*private const string ConnectionString = "Server=LAPTOP-QISL6HJ5;Database=game_history;Integrated Security=SSPI";*/
        private const string ConnectionString = "Server=127.0.0.1,1433;Database=game_history;User Id=SA;Password=P455W0rD;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}