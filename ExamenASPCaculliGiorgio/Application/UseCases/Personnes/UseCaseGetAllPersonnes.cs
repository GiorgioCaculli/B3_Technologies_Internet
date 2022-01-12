using System.Collections.Generic;
using Application.UseCases.Personnes.Dto;
using Application.UseCases.Utils;
using Domain;
using Infrastructure.SqlServer.Repositories.Personne;

namespace Application.UseCases.Personnes
{
    public class UseCaseGetAllPersonnes: IQuery<List<OutputDtoPersonne>>
    {
        private IPersonneRepository _personneRepository;

        public UseCaseGetAllPersonnes(IPersonneRepository personneRepository)
        {
            _personneRepository = personneRepository;
        }

        public List<OutputDtoPersonne> Execute()
        {
            List<Personne> personnes = _personneRepository.GetAll();
            return Mapper.GetInstance().Map<List<OutputDtoPersonne>>(personnes);
        }
    }
}
