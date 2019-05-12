using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Defines implementations for the inherited members which perform student fact related business logic.
    /// </summary>
    public class StudentFactService : FactServiceBase<StudentFact>, IStudentFactService
    {
        /// <inheritdoc />
        protected override DbSet<StudentFact> GetDbSet(ApplicationDbContext context)
        {
            return context.StudentFacts;
        }

        /// <inheritdoc />
        protected override IQueryable<StudentFact> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.CountryDim)
                .OrderBy(fact => fact.YearDimId)
                .ThenBy(fact => fact.CountryDimId);
        }
    }
}