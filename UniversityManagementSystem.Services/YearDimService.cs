using System.Data.Entity;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Defines implementations for the inherited members which perform year dimension related business logic.
    /// </summary>
    public class YearDimService : DimServiceBase<YearDim>, IYearDimService
    {
        /// <inheritdoc />
        protected override DbSet<YearDim> GetDbSet(ApplicationDbContext context)
        {
            return context.YearDims;
        }
    }
}