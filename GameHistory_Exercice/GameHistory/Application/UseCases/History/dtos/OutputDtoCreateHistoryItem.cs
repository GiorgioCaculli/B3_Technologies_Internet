﻿namespace Services.UseCases.History.dtos
{
    public class OutputDtoCreateHistoryItem
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int VideoGameId { get; set; }
        public int TimePlayedMinutes { get; set; }
    }
}