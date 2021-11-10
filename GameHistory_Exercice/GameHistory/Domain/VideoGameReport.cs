namespace Domain
{
    public class VideoGameReport
    {
        public int VideoGameId { get; }
        public int TotalMinutesPlayed { get; }

        public VideoGameReport(int videoGameId, int totalMinutesPlayed)
        {
            VideoGameId = videoGameId;
            TotalMinutesPlayed = totalMinutesPlayed;
        }
        
        // TODO: create Equals method
    }
}