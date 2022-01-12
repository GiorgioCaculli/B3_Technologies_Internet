using Application.UseCases.Parcours.Dto;
using Application.UseCases.Personnes.Dto;
using Application.UseCases.Sessions.Dto;
using AutoMapper;

namespace Application.UseCases.Utils
{
    public class Mapper
    {
        private static AutoMapper.Mapper _instance;

        public static AutoMapper.Mapper GetInstance()
        {
            return _instance ??= CreateInstance();
        }

        private static AutoMapper.Mapper CreateInstance()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<InputDtoPersonne, Domain.Personne>();
                cfg.CreateMap<Domain.Personne, OutputDtoPersonne>();
                cfg.CreateMap<OutputDtoPersonne, Domain.Personne>();

                cfg.CreateMap<InputDtoParcours, Domain.Parcours>();
                cfg.CreateMap<Domain.Parcours, OutputDtoParcours>();
                cfg.CreateMap<OutputDtoParcours, Domain.Parcours>();

                cfg.CreateMap<InputDtoSession, Domain.Session>();
                cfg.CreateMap<Domain.Session, OutputDtoSession>();
                cfg.CreateMap<OutputDtoSession, Domain.Session>();
            });
            return new AutoMapper.Mapper(config);
        }
    }
}
