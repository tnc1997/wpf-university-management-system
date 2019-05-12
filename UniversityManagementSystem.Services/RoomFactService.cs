using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Defines implementations for the inherited members which perform room fact related business logic.
    /// </summary>
    public class RoomFactService : FactServiceBase<RoomFact>, IRoomFactService
    {
        /// <inheritdoc />
        protected override DbSet<RoomFact> GetDbSet(ApplicationDbContext context)
        {
            return context.RoomFacts;
        }

        /// <inheritdoc />
        protected override IQueryable<RoomFact> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.CampusDim)
                .OrderBy(fact => fact.YearDimId)
                .ThenBy(fact => fact.CampusDimId);
        }
    }
}