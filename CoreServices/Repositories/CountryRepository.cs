using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Data;

namespace CoreServices.Repositories.Interface
{
    class CountryRepository: EntityRepository<country>, ICountryRepository
    {
        public CountryRepository(MeetingEntities context) : base(context) { }
        public CountryRepository() : base() { }
    }
}