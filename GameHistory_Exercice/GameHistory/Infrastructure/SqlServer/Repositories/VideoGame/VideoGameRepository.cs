using System.Data;
using System.Data.SqlClient;
using Infrastructure.SqlServer.Utils;

namespace Infrastructure.SqlServer.Repositories.VideoGame
{
    public partial class VideoGameRepository : IVideoGameRepository
    {
        private readonly IDomainFactory<Domain.VideoGame> _factory = new VideoGameFactory();

        public Domain.VideoGame Create(Domain.VideoGame videoGame)
        {
            using var connection = Database.GetConnection();
            connection.Open();

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = ReqCreate
            };

            command.Parameters.AddWithValue("@" + ColName, videoGame.Name);
            command.Parameters.AddWithValue("@" + ColMinutesCompletionTime, videoGame.EstimatedCompletionMinutes);

            videoGame.Id = (int) command.ExecuteScalar();

            return videoGame;
        }

        public Domain.VideoGame GetById(int id)
        {
            using var connection = Database.GetConnection();
            connection.Open();

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = ReqGetById
            };

            command.Parameters.AddWithValue("@" + ColId, id);

            var reader = command.ExecuteReader(CommandBehavior.CloseConnection);

            return reader.Read() ? _factory.CreateFromSqlReader(reader) : null;
        }
    }
}