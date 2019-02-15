using System.Data.Entity;
using UniversityManagementSystem.Data.Contexts;
using UniversityManagementSystem.Data.Entities;

namespace UniversityManagementSystem.Services
{
    public class RoomFactService : FactServiceBase<RoomFact>, IRoomFactService
    {
        protected override DbSet<RoomFact> GetDbSet(ApplicationDbContext context)
        {
            return context.RoomFacts;
        }
    }
}