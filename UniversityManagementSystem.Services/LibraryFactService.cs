using System.Data.Entity;
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
    }
}