using System.Collections.Generic;

namespace Services.UseCases.History.dtos
{
    public class OutputDtoVideoGameReport
    {
        public int TotalMinutesPlayed { get; set; }
        public List<VideoGameReport> Reports { get; set; }

        public class VideoGameReport
        {
            public int VideoGameId { get; set; }
            public string VideoGameName { get; set; }
            public int TotalMinutesPlayed { get; set; }
        }
    }
}