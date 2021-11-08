namespace Services.UseCases.History.dtos
{
    public class InputDtoCreateHistoryItem
    {
        public int UserId { get; set; }
        public int VideoGameId { get; set; }
        public int TimePlayedMinutes { get; set; }
    }
}