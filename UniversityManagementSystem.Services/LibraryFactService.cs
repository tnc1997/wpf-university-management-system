using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class LibraryFactService : FactServiceBase<LibraryFact>, ILibraryFactService
    {
        protected override DbSet<LibraryFact> GetDbSet(ApplicationDbContext context)
        {
            return context.LibraryFacts;
        }

        protected override IQueryable<LibraryFact> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.CampusDim)
                .OrderBy(fact => fact.YearDimId)
                .ThenBy(fact => fact.CampusDimId);
        }
    }
}