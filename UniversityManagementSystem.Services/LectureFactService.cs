using System.Data.Entity;
using System.Linq;
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

        protected override IQueryable<LectureFact> GetQueryable(ApplicationDbContext context)
        {
            return base.GetQueryable(context).Include(fact => fact.ModuleDim).Include(fact => fact.RoomDim);
        }
    }
}