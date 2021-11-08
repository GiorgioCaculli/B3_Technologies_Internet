using System.Data.SqlClient;
using Infrastructure.SqlServer.Utils;

namespace Infrastructure.SqlServer.Repositories.VideoGame
{
    public class VideoGameFactory : IDomainFactory<Domain.VideoGame>
    {
        public Domain.VideoGame CreateFromSqlReader(SqlDataReader reader)
        {
            return new Domain.VideoGame
            {
                Id = reader.GetInt32(reader.GetOrdinal(VideoGameRepository.ColId)),
                EstimatedCompletionMinutes =
                    reader.GetInt32(reader.GetOrdinal(VideoGameRepository.ColMinutesCompletionTime)),
                Name = reader.GetString(reader.GetOrdinal(VideoGameRepository.ColName))
            };
        }
    }
}