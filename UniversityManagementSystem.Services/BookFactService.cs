using System.Data.Entity;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class BookFactService : FactServiceBase<BookFact>, IBookFactService
    {
        protected override DbSet<BookFact> GetDbSet(ApplicationDbContext context)
        {
            return context.BookFacts;
        }
    }
}