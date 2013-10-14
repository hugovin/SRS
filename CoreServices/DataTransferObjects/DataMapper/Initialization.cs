using AutoMapper;
using Data;

namespace CoreServices.DataTransferObjects.DataMapper
{
    class Initialization
    {
        public static bool Initialized = false;

        public static void InitialiceMapper()
        {
            Mapper.CreateMap<building, buildingDto>();
            Mapper.CreateMap<country, countryDto>();
            Mapper.CreateMap<device, deviceDto>();
            Mapper.CreateMap<reservation, reservationDto>();
            Mapper.CreateMap<room, roomDto>();
            Mapper.AssertConfigurationIsValid();
        }
    }
}
