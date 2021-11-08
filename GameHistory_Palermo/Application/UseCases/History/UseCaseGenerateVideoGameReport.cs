using System.Linq;
using Infrastructure.SqlServer.Repositories.VideoGame;
using Services.Services.History;
using Services.UseCases.History.dtos;
using Services.UseCases.Utils;

namespace Services.UseCases.History
{
    public class
        UseCaseGenerateVideoGameReport : IQueryFiltering<OutputDtoVideoGameReport, InputDtoGenerateVideoGameReport>
    {
        private readonly IHistoryService _historyService;
        private readonly IVideoGameRepository _videoGameRepository;

        public UseCaseGenerateVideoGameReport(IVideoGameRepository videoGameRepository, IHistoryService historyService)
        {
            _videoGameRepository = videoGameRepository;
            _historyService = historyService;
        }

        public OutputDtoVideoGameReport Execute(InputDtoGenerateVideoGameReport dto)
        {
            // History allows us to call the method GenerateGameReports
            var history = _historyService.GetHistoryByUserId(dto.UserId);

            // This method does computations and groups video games
            var reports = history.GenerateGameReports();

            // Creation of output dto
            var output = new OutputDtoVideoGameReport
            {
                TotalMinutesPlayed = history.ComputeTotalMinutesPlayed(),
                Reports = reports.Select(report => new OutputDtoVideoGameReport.VideoGameReport
                {
                    TotalMinutesPlayed = report.TotalMinutesPlayed,
                    VideoGameId = report.VideoGameId,
                    // Calling repo because we need to know the name of the video game
                    VideoGameName = _videoGameRepository.GetById(report.VideoGameId).Name
                }).ToList()
            };

            return output;
        }
    }
}