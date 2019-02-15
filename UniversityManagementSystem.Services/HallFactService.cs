using System.Data.Entity;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class HallFactService : FactServiceBase<HallFact>, IHallFactService
    {
        protected override DbSet<HallFact> GetDbSet(ApplicationDbContext context)
        {
            return context.HallFacts;
        }
    }
}