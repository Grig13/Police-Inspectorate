using Police_Inspectorate.Models;
using Police_Inspectorate.Repositories.Interfaces;
using PoliceInspectorate.Context;

namespace Police_Inspectorate.Repositories
{
    public class RequestRepository : BaseRepository<Request>, IRequestRepository
    {
        public RequestRepository(PoliceInspectorateContext dbContext) : base(dbContext)
        {

        }


    }
}
