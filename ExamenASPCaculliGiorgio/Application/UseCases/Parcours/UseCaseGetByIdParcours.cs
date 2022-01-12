using Application.UseCases.Parcours.Dto;
using Application.UseCases.Utils;
using Infrastructure.SqlServer.Repositories.Parcours;

namespace Application.UseCases.Parcours
{
    public class UseCaseGetByIdParcours: IQueryFiltering<OutputDtoParcours, int>
    {
        private readonly IParcoursRepository _parcoursRepository;

        public UseCaseGetByIdParcours(IParcoursRepository parcoursRepository)
        {
            _parcoursRepository = parcoursRepository;
        }

        public OutputDtoParcours Execute(int dto)
        {
            Domain.Parcours parcours = _parcoursRepository.GetById(dto);
            return Mapper.GetInstance().Map<OutputDtoParcours>(parcours);
        }
    }
}
