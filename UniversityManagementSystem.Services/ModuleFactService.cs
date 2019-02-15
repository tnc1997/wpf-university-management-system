using System.Data.Entity;
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
    }
}