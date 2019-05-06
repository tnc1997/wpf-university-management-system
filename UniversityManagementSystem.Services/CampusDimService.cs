using System.Data.Entity;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Defines implementations for the inherited members which perform campus dimension related business logic.
    /// </summary>
    public class CampusDimService : DimServiceBase<CampusDim>, ICampusDimService
    {
        /// <inheritdoc />
        protected override DbSet<CampusDim> GetDbSet(ApplicationDbContext context)
        {
            return context.CampusDims;
        }
    }
}