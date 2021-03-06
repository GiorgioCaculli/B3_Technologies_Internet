using AutoMapper;
using Domain;
using Services.UseCases.History.dtos;
using Services.UseCases.VideoGame.Dtos;

namespace Services.UseCases.Utils
{
    public static class Mapper
    {
        private static AutoMapper.Mapper _instance;

        public static AutoMapper.Mapper GetInstance()
        {
            return _instance ??= CreateMapper();
        }

        private static AutoMapper.Mapper CreateMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                // Source, Destination
                cfg.CreateMap<InputDtoVideoGame, Domain.VideoGame>();
                cfg.CreateMap<Domain.VideoGame, OutputDtoVideoGame>();
                cfg.CreateMap<HistoryItem, OutputDtoCreateHistoryItem>();
                cfg.CreateMap<InputDtoCreateHistoryItem, HistoryItem>();
            });
            return new AutoMapper.Mapper(config);
        }
    }
}