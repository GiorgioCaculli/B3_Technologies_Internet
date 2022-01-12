using System.Data.SqlClient;
using System.IO;
using System.Net;

namespace Infrastructure.SqlServer.System
{
    public class DatabaseManager: IDatabaseManager
    {
        public void CreateTables()
        {
            var script =
                File.ReadAllText(
                    Path.Combine(Directory.GetCurrentDirectory(), "../Infrastructure/SqlServer/Resources/setup.sql") );

            var connection = Database.GetConnection();
            connection.Open();
            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = script
            };

            command.ExecuteNonQuery();
        }

        public void FillTables()
        {
            var script =
                File.ReadAllText(
                    Path.Combine(Directory.GetCurrentDirectory(), "../Infrastructure/SqlServer/Resources/data.sql") );
            var connection = Database.GetConnection();
            connection.Open();
            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = script
            };

            command.ExecuteNonQuery();
        }
    }
}
