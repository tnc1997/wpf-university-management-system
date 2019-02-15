using System.Data.Entity;
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
    }
}