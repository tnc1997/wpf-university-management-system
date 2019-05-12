using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    /// <summary>
    ///     Defines implementations for the inherited members which perform module fact related business logic.
    /// </summary>
    public class ModuleFactService : FactServiceBase<ModuleFact>, IModuleFactService
    {
        /// <inheritdoc />
        protected override DbSet<ModuleFact> GetDbSet(ApplicationDbContext context)
        {
            return context.ModuleFacts;
        }

        /// <inheritdoc />
        protected override IQueryable<ModuleFact> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.CourseDim)
                .OrderBy(fact => fact.YearDimId)
                .ThenBy(fact => fact.CourseDimId);
        }
    }
}