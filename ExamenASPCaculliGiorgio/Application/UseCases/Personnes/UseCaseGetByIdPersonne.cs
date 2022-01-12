using Application.UseCases.Personnes.Dto;
using Application.UseCases.Utils;
using Infrastructure.SqlServer.Repositories.Personne;

namespace Application.UseCases.Personnes
{
    public class UseCaseGetByIdPersonne: IQueryFiltering<OutputDtoPersonne, int>
    {
        private readonly IPersonneRepository _personneRepository;

        public UseCaseGetByIdPersonne(IPersonneRepository personneRepository)
        {
            _personneRepository = personneRepository;
        }

        public OutputDtoPersonne Execute(int dto)
        {
            Domain.Personne personne = _personneRepository.GetById(dto);
            return Mapper.GetInstance().Map<OutputDtoPersonne>(personne);
        }
    }
}
