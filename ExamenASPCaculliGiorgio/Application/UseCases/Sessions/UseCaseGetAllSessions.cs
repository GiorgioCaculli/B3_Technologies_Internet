using System.Collections.Generic;
using Application.UseCases.Sessions.Dto;
using Application.UseCases.Utils;
using Infrastructure.SqlServer.Repositories.Session;

namespace Application.UseCases.Sessions
{
    public class UseCaseGetAllSessions: IQuery<List<OutputDtoSession>>
    {
        private ISessionRepository _sessionRepository;

        public UseCaseGetAllSessions(ISessionRepository sessionRepository)
        {
            _sessionRepository = sessionRepository;
        }

        public List<OutputDtoSession> Execute()
        {
            List<Domain.Session> sessions = _sessionRepository.GetAll();
            return Mapper.GetInstance().Map<List<OutputDtoSession>>(sessions);
        }
    }
}
