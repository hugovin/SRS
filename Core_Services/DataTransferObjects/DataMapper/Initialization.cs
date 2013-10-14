using AutoMapper;

namespace Core_Services.DataTransferObjects.DataMapper
{
    class Initialization
    {
        public static bool Initialized = false;

        public static void InitialiceMapper()
        {
            //Mapper.CreateMap<Campaign, CampaignDto>();
            
            Mapper.AssertConfigurationIsValid();
        }
    }
}
