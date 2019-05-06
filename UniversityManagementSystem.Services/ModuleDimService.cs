using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Defines implementations for the inherited members which perform module dimension related business logic.
    /// </summary>
    public class ModuleDimService : DimServiceBase<ModuleDim>, IModuleDimService
    {
        /// <inheritdoc />
        protected override DbSet<ModuleDim> GetDbSet(ApplicationDbContext context)
        {
            return context.ModuleDims;
        }

        /// <inheritdoc />
        protected override IQueryable<ModuleDim> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context).OrderBy(dim => dim.Code);
        }
    }
}