using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class RoomFactService : FactServiceBase<RoomFact>, IRoomFactService
    {
        protected override DbSet<RoomFact> GetDbSet(ApplicationDbContext context)
        {
            return context.RoomFacts;
        }

        protected override IQueryable<RoomFact> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context).Include(fact => fact.CampusDim);
        }
    }
}