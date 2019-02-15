using System.Data.Entity;
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
    }
}