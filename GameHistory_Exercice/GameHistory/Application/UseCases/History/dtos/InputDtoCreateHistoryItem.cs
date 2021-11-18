using System.ComponentModel.DataAnnotations;

namespace Services.UseCases.History.dtos
{
    public class InputDtoCreateHistoryItem
    {
        public int UserId { get; set; }
        public int VideoGameId { get; set; }
        [Range(0,999999)]
        public int TimePlayedMinutes { get; set; }
    }
}