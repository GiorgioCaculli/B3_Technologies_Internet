using System.Collections.Generic;
using System.Linq;

namespace Domain
{
    public class History
    {
        private readonly List<HistoryItem> _historyItems;

        public History()
        {
            _historyItems = new List<HistoryItem>();
        }

        public void Add(IEnumerable<HistoryItem> items)
        {
            _historyItems.AddRange(items);
        }

        // TODO: to test
        public IEnumerable<VideoGameReport> GenerateGameReports()
        {
            return _historyItems.GroupBy(item => item.VideoGameId)
                .Select(g =>
                    new VideoGameReport(g.Key, g.Sum(item => item.TimePlayedMinutes))
                ).ToList();
        }

        // TODO: to test
        public int ComputeTotalMinutesPlayed()
        {
            return _historyItems.Sum(item => item.TimePlayedMinutes);
        }
    }
}