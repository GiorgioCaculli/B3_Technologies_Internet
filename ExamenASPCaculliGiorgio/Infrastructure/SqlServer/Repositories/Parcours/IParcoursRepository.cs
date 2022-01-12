using System.Collections.Generic;
using Infrastructure.SqlServer.Utils;

namespace Infrastructure.SqlServer.Repositories.Parcours
{
    public interface IParcoursRepository: IElementQueryableById<Domain.Parcours>
    {
        List<Domain.Parcours> GetAll();
        Domain.Parcours Create(Domain.Parcours parcours);
    }
}
