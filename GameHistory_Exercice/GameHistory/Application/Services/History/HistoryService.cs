using Infrastructure.SqlServer.Repositories.History;

namespace Services.Services.History
{
    public class HistoryService : IHistoryService
    {
        private readonly IHistoryRepository _historyRepository;

        public HistoryService(IHistoryRepository historyRepository)
        {
            _historyRepository = historyRepository;
        }

        public Domain.History GetHistoryByUserId(int userId)
        {
            // Fetch all history item for creating an instance of History
            var historyItems = _historyRepository.GetHistoryItemsOf(userId);

            var history = new Domain.History();
            history.Add(historyItems);

            return history;
        }
    }
}