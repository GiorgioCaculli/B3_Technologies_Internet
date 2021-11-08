using Infrastructure.SqlServer.Repositories.VideoGame;
using Services.UseCases.Utils;
using Services.UseCases.VideoGame.Dtos;

namespace Services.UseCases.VideoGame
{
    public class UseCaseCreateVideoGame: IWriting<OutputDtoVideoGame, InputDtoVideoGame>
    {
        private readonly IVideoGameRepository _videoGameRepository;

        public UseCaseCreateVideoGame(IVideoGameRepository videoGameRepository)
        {
            _videoGameRepository = videoGameRepository;
        }

        public OutputDtoVideoGame Execute(InputDtoVideoGame dto)
        {
            var videoGameFromDto = Mapper.GetInstance().Map<Domain.VideoGame>(dto);

            var videoGameFromDb = _videoGameRepository.Create(videoGameFromDto);

            return Mapper.GetInstance().Map<OutputDtoVideoGame>(videoGameFromDb);
        }
    }
}