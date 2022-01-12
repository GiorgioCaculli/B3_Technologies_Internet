using System.Collections.Generic;
using Application.UseCases.Parcours.Dto;
using Application.UseCases.Utils;
using Infrastructure.SqlServer.Repositories.Parcours;

namespace Application.UseCases.Parcours
{
    public class UseCaseGetAllParcours: IQuery<List<OutputDtoParcours>>
    {
        private IParcoursRepository _parcoursRepository;

        public UseCaseGetAllParcours(IParcoursRepository parcoursRepository)
        {
            _parcoursRepository = parcoursRepository;
        }

        public List<OutputDtoParcours> Execute()
        {
            List<Domain.Parcours> parcours = _parcoursRepository.GetAll();
            return Mapper.GetInstance().Map<List<OutputDtoParcours>>(parcours);
        }
    }
}
