using Police_Inspectorate.Models;
using Police_Inspectorate.Repositories.Interfaces;
using PoliceInspectorate.Context;

namespace Police_Inspectorate.Repositories
{
    public class InspectorateChiefRepository : BaseRepository<InspectorateChief>, IInspectorateChiefRepository
    {
        public InspectorateChiefRepository(PoliceInspectorateContext dbContext) : base(dbContext)
        {

        }


    }
}
