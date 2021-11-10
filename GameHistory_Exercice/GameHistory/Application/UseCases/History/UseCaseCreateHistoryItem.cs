using Domain;
using Infrastructure.SqlServer.Repositories.History;
using Services.UseCases.History.dtos;
using Services.UseCases.Utils;

namespace Services.UseCases.History
{
    public class UseCaseCreateHistoryItem: IWriting<OutputDtoCreateHistoryItem, InputDtoCreateHistoryItem>
    {
        private readonly IHistoryRepository _historyRepository;

        public UseCaseCreateHistoryItem(IHistoryRepository historyRepository)
        {
            _historyRepository = historyRepository;
        }

        public OutputDtoCreateHistoryItem Execute(InputDtoCreateHistoryItem dto)
        {
            var itemFromDto = Mapper.GetInstance().Map<HistoryItem>(dto);

            var itemFromDb = _historyRepository.CreateItem(itemFromDto);

            return Mapper.GetInstance().Map<OutputDtoCreateHistoryItem>(itemFromDb);
        }
    }
}