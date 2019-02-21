using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class EnrolmentFactService : FactServiceBase<EnrolmentFact>, IEnrolmentFactService
    {
        protected override DbSet<EnrolmentFact> GetDbSet(ApplicationDbContext context)
        {
            return context.EnrolmentFacts;
        }

        protected override IQueryable<EnrolmentFact> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.ModuleDim)
                .OrderBy(fact => fact.YearDimId)
                .ThenBy(fact => fact.ModuleDimId);
        }
    }
}