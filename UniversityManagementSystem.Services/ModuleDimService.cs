using System.Data.Entity;
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
    }
}