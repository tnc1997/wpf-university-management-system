using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Defines implementations for the inherited members which perform enrolment fact related business logic.
    /// </summary>
    public class EnrolmentFactService : FactServiceBase<EnrolmentFact>, IEnrolmentFactService
    {
        /// <inheritdoc />
        protected override DbSet<EnrolmentFact> GetDbSet(ApplicationDbContext context)
        {
            return context.EnrolmentFacts;
        }

        /// <inheritdoc />
        protected override IQueryable<EnrolmentFact> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.ModuleDim)
                .OrderBy(fact => fact.YearDimId)
                .ThenBy(fact => fact.ModuleDimId);
        }
    }
}