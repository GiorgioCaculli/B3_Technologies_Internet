using System.Collections.Generic;
using Domain;

namespace Infrastructure.SqlServer.Repositories.History
{
    public interface IHistoryRepository
    {
        HistoryItem CreateItem(HistoryItem historyItem);

        IEnumerable<HistoryItem> GetHistoryItemsOf(int userId);
    }
}