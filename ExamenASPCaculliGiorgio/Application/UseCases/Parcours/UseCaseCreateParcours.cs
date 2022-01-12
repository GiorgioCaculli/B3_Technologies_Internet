using Application.UseCases.Parcours.Dto;
using Application.UseCases.Utils;
using Infrastructure.SqlServer.Repositories.Parcours;

namespace Application.UseCases.Parcours
{
    public class UseCaseCreateParcours: IWriting<OutputDtoParcours, InputDtoParcours>
    {
        private readonly IParcoursRepository _parcoursRepository;

        public UseCaseCreateParcours(IParcoursRepository parcoursRepository)
        {
            _parcoursRepository = parcoursRepository;
        }

        public OutputDtoParcours Execute(InputDtoParcours dto)
        {
            var parcoursFromDto = Mapper.GetInstance().Map<Domain.Parcours>(dto);
            var parcoursFromDb = _parcoursRepository.Create(parcoursFromDto);
            return Mapper.GetInstance().Map<OutputDtoParcours>(parcoursFromDb);
        }
    }
}
