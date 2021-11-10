namespace Domain
{
    public class VideoGame
    {
        public int Id { get; set; }

        public string Name { get; set; }

        // @Invariant > 0
        public int EstimatedCompletionMinutes { get; set; }
    }
}