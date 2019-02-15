using System.Data.Entity;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class AssignmentFactService : FactServiceBase<AssignmentFact>, IAssignmentFactService
    {
        protected override DbSet<AssignmentFact> GetDbSet(ApplicationDbContext context)
        {
            return context.AssignmentFacts;
        }
    }
}