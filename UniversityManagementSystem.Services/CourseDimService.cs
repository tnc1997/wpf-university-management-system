using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Defines implementations for the inherited members which perform course dimension related business logic.
    /// </summary>
    public class CourseDimService : DimServiceBase<CourseDim>, ICourseDimService
    {
        /// <inheritdoc />
        protected override DbSet<CourseDim> GetDbSet(ApplicationDbContext context)
        {
            return context.CourseDims;
        }

        /// <inheritdoc />
        protected override IQueryable<CourseDim> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context).OrderBy(dim => dim.Name);
        }
    }
}