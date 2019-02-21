using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class HallFactService : FactServiceBase<HallFact>, IHallFactService
    {
        protected override DbSet<HallFact> GetDbSet(ApplicationDbContext context)
        {
            return context.HallFacts;
        }

        protected override IQueryable<HallFact> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.CampusDim)
                .OrderBy(fact => fact.YearDimId)
                .ThenBy(fact => fact.CampusDimId);
        }
    }
}