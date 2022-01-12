using System.Collections.Generic;
using Infrastructure.SqlServer.Utils;

namespace Infrastructure.SqlServer.Repositories.Personne
{
    public interface IPersonneRepository: IElementQueryableById<Domain.Personne>
    {
        List<Domain.Personne> GetAll();
        Domain.Personne Create(Domain.Personne personne);
    }
}
