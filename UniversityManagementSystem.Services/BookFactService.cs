using System.Data.Entity;
using System.Linq;
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

        protected override IQueryable<BookFact> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context).Include(fact => fact.LibraryDim);
        }
    }
}