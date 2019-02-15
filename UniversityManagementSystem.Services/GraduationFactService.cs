using System.Data.Entity;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class GraduationFactService : FactServiceBase<GraduationFact>, IGraduationFactService
    {
        protected override DbSet<GraduationFact> GetDbSet(ApplicationDbContext context)
        {
            return context.GraduationFacts;
        }
    }
}