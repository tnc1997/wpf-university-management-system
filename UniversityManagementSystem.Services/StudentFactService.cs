using System.Data.Entity;
using System.Linq;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class StudentFactService : FactServiceBase<StudentFact>, IStudentFactService
    {
        protected override DbSet<StudentFact> GetDbSet(ApplicationDbContext context)
        {
            return context.StudentFacts;
        }

        protected override IQueryable<StudentFact> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context)
                .Include(fact => fact.CountryDim)
                .OrderBy(fact => fact.YearDimId)
                .ThenBy(fact => fact.CountryDimId);
        }
    }
}