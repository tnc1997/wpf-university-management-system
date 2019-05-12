using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Defines implementations for the inherited members which perform library fact related business logic.
    /// </summary>
    public class LibraryFactService : FactServiceBase<LibraryFact>, ILibraryFactService
    {
        /// <inheritdoc />
        protected override DbSet<LibraryFact> GetDbSet(ApplicationDbContext context)
        {
            return context.LibraryFacts;
        }

        /// <inheritdoc />
        protected override IQueryable<LibraryFact> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.CampusDim)
                .OrderBy(fact => fact.YearDimId)
                .ThenBy(fact => fact.CampusDimId);
        }
    }
}