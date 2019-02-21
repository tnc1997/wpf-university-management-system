using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class RentalFactService : FactServiceBase<RentalFact>, IRentalFactService
    {
        protected override DbSet<RentalFact> GetDbSet(ApplicationDbContext context)
        {
            return context.RentalFacts;
        }

        protected override IQueryable<RentalFact> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.BookDim)
                .Include(fact => fact.UserDim)
                .OrderBy(fact => fact.YearDimId)
                .ThenBy(fact => fact.BookDimId)
                .ThenBy(fact => fact.UserDimId);
        }
    }
}