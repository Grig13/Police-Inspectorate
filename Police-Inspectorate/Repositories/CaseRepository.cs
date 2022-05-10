using Police_Inspectorate.Models;
using Police_Inspectorate.Repositories.Interfaces;
using PoliceInspectorate.Context;

namespace Police_Inspectorate.Repositories
{
    public class CaseRepository : BaseRepository<Case>, ICaseRepository
    {
        public CaseRepository(PoliceInspectorateContext dbContext) : base(dbContext)
        {
        }
    }
}
