using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Defines implementations for the inherited members which perform graduation fact related business logic.
    /// </summary>
    public class GraduationFactService : FactServiceBase<GraduationFact>, IGraduationFactService
    {
        /// <inheritdoc />
        protected override DbSet<GraduationFact> GetDbSet(ApplicationDbContext context)
        {
            return context.GraduationFacts;
        }

        /// <inheritdoc />
        protected override IQueryable<GraduationFact> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.CourseDim)
                .OrderBy(fact => fact.YearDimId)
                .ThenBy(fact => fact.CourseDimId);
        }
    }
}