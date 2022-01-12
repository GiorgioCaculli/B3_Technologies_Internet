using Application.UseCases.Sessions.Dto;
using Application.UseCases.Utils;
using Infrastructure.SqlServer.Repositories.Session;

namespace Application.UseCases.Sessions
{
    public class UseCaseGetByIdSession: IQueryFiltering<OutputDtoSession, int>
    {
        private readonly ISessionRepository _sessionRepository;

        public UseCaseGetByIdSession(ISessionRepository sessionRepository)
        {
            _sessionRepository = sessionRepository;
        }

        public OutputDtoSession Execute(int dto)
        {
            Domain.Session session = _sessionRepository.GetById(dto);
            return Mapper.GetInstance().Map<OutputDtoSession>(session);
        }
    }
}
