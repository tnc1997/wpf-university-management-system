using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Defines implementations for the inherited members which perform hall fact related business logic.
    /// </summary>
    public class HallFactService : FactServiceBase<HallFact>, IHallFactService
    {
        /// <inheritdoc />
        protected override DbSet<HallFact> GetDbSet(ApplicationDbContext context)
        {
            return context.HallFacts;
        }

        /// <inheritdoc />
        protected override IQueryable<HallFact> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.CampusDim)
                .OrderBy(fact => fact.YearDimId)
                .ThenBy(fact => fact.CampusDimId);
        }
    }
}