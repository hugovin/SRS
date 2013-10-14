using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreServices.Repositories.Interface;
using Data;

namespace CoreServices.Repositories
{
    class BuildingRepository: EntityRepository<building>, IBuildingRepository
    {
        public BuildingRepository(MeetingEntities context) : base(context) { }
        public BuildingRepository() : base() { }
    }
}

