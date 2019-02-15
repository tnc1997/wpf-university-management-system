using System.Data.Entity;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class LectureFactService : FactServiceBase<LectureFact>, ILectureFactService
    {
        protected override DbSet<LectureFact> GetDbSet(ApplicationDbContext context)
        {
            return context.LectureFacts;
        }
    }
}