using AutoMapper;
using Evenement.Model.Dto;
using VoitureAPi2.Model;

namespace Evenement
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(conf =>
            {
                conf.CreateMap<EventsDto, Events>();
                conf.CreateMap<Events, EventsDto>();
            });
            return mappingConfig;
        }
    }
}
