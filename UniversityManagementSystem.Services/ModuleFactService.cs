using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class ModuleFactService : FactServiceBase<ModuleFact>, IModuleFactService
    {
        protected override DbSet<ModuleFact> GetDbSet(ApplicationDbContext context)
        {
            return context.ModuleFacts;
        }

        protected override IQueryable<ModuleFact> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.CourseDim)
                .OrderBy(fact => fact.YearDimId)
                .ThenBy(fact => fact.CourseDimId);
        }
    }
}