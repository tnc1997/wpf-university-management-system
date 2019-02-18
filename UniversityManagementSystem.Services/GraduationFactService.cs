using System.Data.Entity;
using System.Linq;
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

        protected override IQueryable<GraduationFact> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context).Include(fact => fact.CourseDim);
        }
    }
}