using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class AssignmentFactService : FactServiceBase<AssignmentFact>, IAssignmentFactService
    {
        protected override DbSet<AssignmentFact> GetDbSet(ApplicationDbContext context)
        {
            return context.AssignmentFacts;
        }

        protected override IQueryable<AssignmentFact> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.ModuleDim)
                .OrderBy(fact => fact.YearDimId)
                .ThenBy(fact => fact.ModuleDimId);
        }
    }
}