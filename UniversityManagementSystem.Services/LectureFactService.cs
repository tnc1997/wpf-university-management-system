using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Defines implementations for the inherited members which perform lecture fact related business logic.
    /// </summary>
    public class LectureFactService : FactServiceBase<LectureFact>, ILectureFactService
    {
        /// <inheritdoc />
        protected override DbSet<LectureFact> GetDbSet(ApplicationDbContext context)
        {
            return context.LectureFacts;
        }

        /// <inheritdoc />
        protected override IQueryable<LectureFact> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.ModuleDim)
                .Include(fact => fact.RoomDim)
                .OrderBy(fact => fact.YearDimId)
                .ThenBy(fact => fact.RoomDimId)
                .ThenBy(fact => fact.ModuleDimId);
        }
    }
}