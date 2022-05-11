using Police_Inspectorate.Models;
using Police_Inspectorate.Repositories.Interfaces;
using PoliceInspectorate.Context;

namespace Police_Inspectorate.Repositories
{
    public class MeetingRepository : BaseRepository<Meeting>, IMeetingRepository
    {
        public MeetingRepository(PoliceInspectorateContext dbContext) : base(dbContext)
        {

        }


    }
}
