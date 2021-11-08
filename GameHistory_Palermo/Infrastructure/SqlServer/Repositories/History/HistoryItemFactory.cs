using System.Data.SqlClient;
using Domain;
using Infrastructure.SqlServer.Utils;

namespace Infrastructure.SqlServer.Repositories.History
{
    public class HistoryItemFactory : IDomainFactory<HistoryItem>
    {
        public HistoryItem CreateFromSqlReader(SqlDataReader reader)
        {
            return new HistoryItem
            {
                Id = reader.GetInt32(reader.GetOrdinal(HistoryRepository.ColId)),
                UserId = reader.GetInt32(reader.GetOrdinal(HistoryRepository.ColId)),
                VideoGameId = reader.GetInt32(reader.GetOrdinal(HistoryRepository.ColGameId)),
                TimePlayedMinutes = reader.GetInt32(reader.GetOrdinal(HistoryRepository.ColMinutesPlayed))
            };
        }
    }
}