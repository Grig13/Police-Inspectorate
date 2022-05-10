using Police_Inspectorate.Models;
using Police_Inspectorate.Repositories.Interfaces;
using PoliceInspectorate.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Police_Inspectorate.Repositories
{
    public class PoliceAgentRepository : BaseRepository<PoliceAgent>, IPoliceAgentRepository
    {
        public PoliceAgentRepository(PoliceInspectorateContext dbContext) : base(dbContext)
        {

        }

      
    }
}
