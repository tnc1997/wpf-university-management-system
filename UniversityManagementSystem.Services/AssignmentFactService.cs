using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Defines implementations for the inherited members which perform assignment fact related business logic.
    /// </summary>
    public class AssignmentFactService : FactServiceBase<AssignmentFact>, IAssignmentFactService
    {
        /// <inheritdoc />
        protected override DbSet<AssignmentFact> GetDbSet(ApplicationDbContext context)
        {
            return context.AssignmentFacts;
        }

        /// <inheritdoc />
        protected override IQueryable<AssignmentFact> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.ModuleDim)
                .OrderBy(fact => fact.YearDimId)
                .ThenBy(fact => fact.ModuleDimId);
        }
    }
}