using Application.UseCases.Personnes.Dto;
using Application.UseCases.Utils;
using Infrastructure.SqlServer.Repositories.Personne;

namespace Application.UseCases.Personnes
{
    public class UseCaseCreatePersonne: IWriting<OutputDtoPersonne, InputDtoPersonne>
    {
        private readonly IPersonneRepository _personneRepository;

        public UseCaseCreatePersonne(IPersonneRepository personneRepository)
        {
            _personneRepository = personneRepository;
        }

        public OutputDtoPersonne Execute(InputDtoPersonne dto)
        {
            var personneFromDto = Mapper.GetInstance().Map<Domain.Personne>(dto);
            var personneFromDb = _personneRepository.Create(personneFromDto);
            return Mapper.GetInstance().Map<OutputDtoPersonne>(personneFromDb);
        }
    }
}
