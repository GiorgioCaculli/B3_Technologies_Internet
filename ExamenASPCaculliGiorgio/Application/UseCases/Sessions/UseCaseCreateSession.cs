using Application.UseCases.Sessions.Dto;
using Application.UseCases.Utils;
using Infrastructure.SqlServer.Repositories.Session;

namespace Application.UseCases.Sessions
{
    public class UseCaseCreateSession: IWriting<OutputDtoSession, InputDtoSession>
    {
        private readonly ISessionRepository _sessionRepository;

        public UseCaseCreateSession(ISessionRepository sessionRepository)
        {
            _sessionRepository = sessionRepository;
        }

        public OutputDtoSession Execute(InputDtoSession dto)
        {
            var sessionFromDto = Mapper.GetInstance().Map<Domain.Session>(dto);
            var sessionFromDb = _sessionRepository.Create(sessionFromDto);
            return Mapper.GetInstance().Map<OutputDtoSession>(sessionFromDb);
        }
    }
}
