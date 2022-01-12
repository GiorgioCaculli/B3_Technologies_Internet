using System.Collections.Generic;
using Infrastructure.SqlServer.Utils;

namespace Infrastructure.SqlServer.Repositories.Session
{
    public interface ISessionRepository: IElementQueryableById<Domain.Session>
    {
        List<Domain.Session> GetAll();

        Domain.Session Create(Domain.Session session);
    }
}
