using System.Data.SqlClient;

namespace Infrastructure.SqlServer
{
    public class Database
    {
        /* Windows */
        /*private const string ConnectionString =
            "Server=LAPTOP-9U0H5TN6;Database=examen_ti_janvier_2022;Integrated Security=SSPI";*/

        /* UNIX */
        private const string ConnectionString = "Server=127.0.0.1,1433;Database=examen_ti_janvier_2022;User Id=SA;Password=P455W0rD;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
