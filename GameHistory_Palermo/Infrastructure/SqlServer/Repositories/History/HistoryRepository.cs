using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Domain;
using Infrastructure.SqlServer.Utils;

namespace Infrastructure.SqlServer.Repositories.History
{
    public partial class HistoryRepository : IHistoryRepository
    {
        private readonly IDomainFactory<HistoryItem> _factory = new HistoryItemFactory();

        public HistoryItem CreateItem(HistoryItem historyItem)
        {
            using var connection = Database.GetConnection();
            connection.Open();

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = ReqCreate
            };

            command.Parameters.AddWithValue("@" + ColUserId, historyItem.UserId);
            command.Parameters.AddWithValue("@" + ColGameId, historyItem.VideoGameId);
            command.Parameters.AddWithValue("@" + ColMinutesPlayed, historyItem.TimePlayedMinutes);

            historyItem.Id = (int) command.ExecuteScalar();

            return historyItem;
        }

        public IEnumerable<HistoryItem> GetHistoryItemsOf(int userId)
        {
            var items = new List<HistoryItem>();

            using var connection = Database.GetConnection();
            connection.Open();

            var command = new SqlCommand
            {
                Connection = connection,
                CommandText = ReqGetHistoryItemsOfUser
            };

            command.Parameters.AddWithValue("@" + ColUserId, userId);

            var reader = command.ExecuteReader(CommandBehavior.CloseConnection);

            while (reader.Read())
                items.Add(_factory.CreateFromSqlReader(reader));

            return items;
        }
    }
}