using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Defines implementations for the inherited members which perform book fact related business logic.
    /// </summary>
    public class BookFactService : FactServiceBase<BookFact>, IBookFactService
    {
        /// <inheritdoc />
        protected override DbSet<BookFact> GetDbSet(ApplicationDbContext context)
        {
            return context.BookFacts;
        }

        /// <inheritdoc />
        protected override IQueryable<BookFact> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.LibraryDim)
                .OrderBy(fact => fact.YearDimId)
                .ThenBy(fact => fact.LibraryDimId);
        }
    }
}