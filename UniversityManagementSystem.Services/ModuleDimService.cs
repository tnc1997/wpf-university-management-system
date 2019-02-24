using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class ModuleDimService : DimServiceBase<ModuleDim>, IModuleDimService
    {
        protected override DbSet<ModuleDim> GetDbSet(ApplicationDbContext context)
        {
            return context.ModuleDims;
        }

        protected override IQueryable<ModuleDim> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context).OrderBy(dim => dim.Code);
        }
    }
}