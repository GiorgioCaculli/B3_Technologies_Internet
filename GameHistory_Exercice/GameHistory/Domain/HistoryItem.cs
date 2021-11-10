namespace Domain
{
    public class HistoryItem
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int VideoGameId { get; set; }
        // @Invariant > 0
        public int TimePlayedMinutes { get; set; }

        public HistoryItem(int userId, int videoGameId, int timePlayedMinutes)
        {
            UserId = userId;
            VideoGameId = videoGameId;
            TimePlayedMinutes = timePlayedMinutes;
        }

        public HistoryItem()
        {
        }
    }
}