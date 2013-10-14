using System.Data.Objects;
using Data;
using Ninject.Modules;
using CoreServices.Repositories;
using CoreServices.Repositories.Interface;

namespace CoreServices.Module
{
    class RepositoryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ObjectContext>().To<MeetingEntities>();
            Bind<MeetingEntities>().ToMethod(context => new MeetingEntities());
            Bind<ICountryRepository>().To<CountryRepository>();
            Bind<IBuildingRepository>().To<BuildingRepository>();
           
        }

    }
}
